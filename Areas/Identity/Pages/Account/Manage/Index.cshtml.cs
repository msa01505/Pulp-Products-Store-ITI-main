using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pulp.Areas.Identity.Data;
using Pulp.Services;

namespace Pulp.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<PulpProjectUser> _userManager;
        private readonly SignInManager<PulpProjectUser> _signInManager;
        private readonly IBuyerRepoService _buyerRepoService;

        public IndexModel(
            UserManager<PulpProjectUser> userManager,
            SignInManager<PulpProjectUser> signInManager,
            IBuyerRepoService buyerRepoService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _buyerRepoService = buyerRepoService;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Phone]
            [Display(Name = "Phone number")]
            [StringLength(11, ErrorMessage = "Please Enter a valid phone number")]
            public string PhoneNumber { get; set; }
        }

        private async Task LoadAsync(PulpProjectUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!User.IsInRole("Buyer"))
            {
                return NotFound("Only Customers Can Provide Phone Number");
            }
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }
           
            //get current buyer by email
            var buyer = _buyerRepoService.GetBuyerByUsername(user.Email);

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);

                //set phone number in buyers table 
                buyer.PhoneNumber = Input.PhoneNumber;
                _buyerRepoService.UpdateBuyer(buyer.UserID, buyer);

                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
