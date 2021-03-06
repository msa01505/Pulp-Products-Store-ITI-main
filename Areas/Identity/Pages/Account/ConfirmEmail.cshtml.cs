using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Pulp.Areas.Identity.Data;
using Pulp.Models;
using Pulp.Services;

namespace Pulp.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ConfirmEmailModel : PageModel
    {
        private readonly UserManager<PulpProjectUser> _userManager;
        private readonly IBuyerRepoService _buyerRepoService;
        private readonly IAddressRepoService _addressRepoService;

        public ConfirmEmailModel(UserManager<PulpProjectUser> userManager, IBuyerRepoService buyerRepoService, IAddressRepoService repoService)
        {
            _userManager = userManager;
            _buyerRepoService = buyerRepoService;
            _addressRepoService = repoService;
        }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return RedirectToPage("/Index");
            }

            //var user = await _userManager.FindByIdAsync(userId);
            var user = await _userManager.Users.Include(u => u.Address).FirstOrDefaultAsync(us => us.Id == userId);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userId}'.");
            }

            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            var result = await _userManager.ConfirmEmailAsync(user, code);

            //address
            
            
            //add to second database
            Buyer buyer = new Buyer()
            {
                BirthDate = user.BirthDate,
                Username = user.UserName,
                PictureUri = user.PictureUri,
                Address = new Address() { ApartmentNom= user.Address.ApartmentNom, BuildingNom = user.Address.BuildingNom,
                Street= user.Address.Street, City = user.Address.City, ZipCode = user.Address.ZipCode
                }

            };

            _buyerRepoService.Insert(buyer);


            StatusMessage = result.Succeeded ? "Thank you for confirming your email." : "Error confirming your email.";
            return RedirectToPage("/Account/Login", new { area = "Identity" });
            //return RedirectToAction("Index");
        }
    }
}
