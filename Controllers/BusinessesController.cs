using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pulp.Areas.Identity.Data;
using Pulp.Models;
using Pulp.Services;
using Pulp.ViewModels;

namespace Pulp.Controllers
{
    [Authorize(Roles ="Admin,Buyer")]
    public class BusinessesController : Controller
    {
        private readonly IBusinessRepoService businessRepository;
        private readonly ICategoryTypeRepoService categoryTypeRepository;
        private readonly ICategoryItemRepoService categoryItemRepository;
        private readonly IOrderRepoService orderRepoService;
        private readonly UserManager<PulpProjectUser> UserManager;
        private readonly IBuyerRepoService buyerRepoService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public BusinessesController(IBusinessRepoService _businessRepository, ICategoryTypeRepoService _categoryTypeRepoService,
           ICategoryItemRepoService _categoryItemRepoService,
           IOrderRepoService _orderRepoService,
           UserManager<PulpProjectUser> _userManager,
           IBuyerRepoService _buyerRepoService, IWebHostEnvironment _webHostEnvironment)

        {
            businessRepository = _businessRepository;
            categoryTypeRepository = _categoryTypeRepoService;
            categoryItemRepository = _categoryItemRepoService;
            orderRepoService = _orderRepoService;
            UserManager = _userManager;
            buyerRepoService = _buyerRepoService;
            webHostEnvironment = _webHostEnvironment;

        }

        // GET: Pulps
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("Buyer"))
            {
                Buyer curr = buyerRepoService?.GetBuyerByUsername(UserManager.GetUserName(User));
                var order = orderRepoService?.GetAllOrdersOfUserID(curr.UserID)?.FirstOrDefault(o => o.orderStatus == OrderStatus.Initial);
                if (order == null)
                    return View(businessRepository.GetAllBusinessess());
                var categoryItemID = order?.OrderItems?.FirstOrDefault()?.CategoryItemID;
                var categoryTypeID = categoryItemRepository?.GetAllCategoryItems()?.Where(o => o.CategoryItemID == categoryItemID)?.FirstOrDefault()?.CategoryTypeId;
                var businessID = categoryTypeRepository?.GetBusinessID(categoryTypeID);

              


                return RedirectToAction("Details", "Businesses", new { id = businessID });

            }
            return View(businessRepository.GetAllBusinessess());
        }
        [HttpPost]
        public async Task<IActionResult> Index(string Name)
        {
            // Pulp temp = this.businessRepository.SearchByName(Name);
            if (Name == null)
            {
                return View(businessRepository.GetAllBusinessess());
            }
            List<Business> serResult = businessRepository.Search(Name);
            //if(temp==null)
            //{
            //    return View("NotFound");
            //}
            if (serResult == null)
            {
                return View("NotFound");
            }
            // ViewBag.SearchResult = temp;
            ViewBag.SearchResult = serResult;
            return View();
        }

        // GET: Pulps/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var business = businessRepository.GetDetails(id);
            if (business == null)
            {
                return NotFound();

            }
            Buyer buyer = buyerRepoService.GetBuyerByUsername(UserManager.GetUserName(User));
            List<Order> cartOrders = new List<Order>();
            if (buyer != null)
            {
                cartOrders = orderRepoService.GetAllOrdersOfUserID(buyer.UserID);

            }

            Business temp = new Business();

            if (cartOrders.Count <= 0)
            {
                temp = business;
            }
            else
            {
                foreach (var order in cartOrders)
                {
                    foreach (var item in order.OrderItems)
                    {
                        // current.total += item.Price * item.Units;
                        var ct = categoryItemRepository.GetDetails(item.CategoryItemID);
                        item.ItemOrdered = ct;
                        int? categoryTypeID = item.ItemOrdered.CategoryTypeId;
                        int? resID = categoryTypeRepository.GetBusinessID(categoryTypeID);
                        if (business.BusinessID != resID)
                        {
                            temp = businessRepository.GetDetails(resID);
                        }
                        else
                        {
                            temp = business;
                        }
                    }
                }
            }

            BusinessCategoryType tempModel = new BusinessCategoryType()
            {
                business = business,
                categoryTypes = categoryTypeRepository.GetAllCategoryTypesOfResID(id),
                cartRest = temp

            };
            tempModel.Flag = "flex";
            return View(tempModel);
        }

        [HttpPost]
        public async Task<IActionResult> Details(int id, string Name)
        {
            if (id == null)
            {
                return NotFound();
            }
            var business = businessRepository.GetDetails(id);
            if (business == null)
            {
                return NotFound();

            }
            Buyer buyer = buyerRepoService.GetBuyerByUsername(UserManager.GetUserName(User));
            List<Order> cartOrders = new List<Order>();
            if (buyer != null)
            {
                cartOrders = orderRepoService.GetAllOrdersOfUserID(buyer.UserID);

            }

            Business temp = new Business();

            if (cartOrders.Count <= 0)
            {
                temp = business;
            }
            else
            {
                foreach (var order in cartOrders)
                {
                    foreach (var item in order.OrderItems)
                    {
                        // current.total += item.Price * item.Units;
                        var ct = categoryItemRepository.GetDetails(item.CategoryItemID);
                        item.ItemOrdered = ct;
                        int? categoryTypeID = item.ItemOrdered.CategoryTypeId;
                        int? resID = categoryTypeRepository.GetBusinessID(categoryTypeID);
                        if (business.BusinessID != resID)
                        {
                            temp = businessRepository.GetDetails(resID);
                        }
                        else
                        {
                            temp = business;
                        }
                    }
                }
            }

            BusinessCategoryType tempModel = new BusinessCategoryType()
            {
                business = business,
                categoryTypes = categoryTypeRepository.GetAllCategoryTypesOfResID(id),
                cartRest = temp

            };
            if (Name == null)
            {
                tempModel.Flag = "flex";
                return View(tempModel);

            }
            List<CategoryItem> serResult = categoryItemRepository.Search(Name, id);
            if (serResult == null)
            {
                tempModel.Flag = "flex";
                return View("NotFound");
            }
            ViewBag.SearchResult = serResult;
            tempModel.Flag = "none";

            return View(tempModel);
        }

        // GET: Pulps/Create
        public IActionResult Create()
        {
            return View();
        }

        private Business RestaurantWithUploadedFile(BusinessViewModel model)
        {
            string uniqueFileName = null;

            // If the Photo property on the incoming model object is not null, then the user
            // has selected an image to upload.
            if (model.Image != null)
            {
                // The image must be uploaded to the images folder in wwwroot
                // To get the path of the wwwroot folder we are using the inject
                // HostingEnvironment service provided by ASP.NET Core
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                // To make sure the file name is unique we are appending a new
                // GUID value and and an underscore to the file name
                //uniqueFileName = model.Name+"-"+model.Describtion.Replace(" ", string.Empty) + Path.GetExtension(model.Image.FileName);
                uniqueFileName = "business" + "-" + (model.Name.Replace(" ", "")) + Path.GetExtension(model.Image.FileName);
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                // Use CopyTo() method provided by IFormFile interface to
                // copy the file to wwwroot/images folder
                model.Image.CopyTo(new FileStream(filePath, FileMode.Create));
            }


            Business business = new Business
            {
                Name = model.Name,
                Describtion = model.Describtion,
                // Store the file name in PhotoPath property of the employee object
                // which gets saved to the Employees database table
                PicUri = uniqueFileName,

            };

            return business;
        }

        // POST: Pulps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BusinessViewModel model)
        {
            if (ModelState.IsValid)
            {


                businessRepository.Insert(RestaurantWithUploadedFile(model));
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Pulps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var business = businessRepository.GetDetails(id);
            if (business == null)
            {
                return NotFound();
            }
            BusinessViewModel model = new BusinessViewModel { BusinessID = business.BusinessID, Name = business.Name, Describtion = business.Describtion };
            return View(model);
        }

        // POST: Pulps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, BusinessViewModel model)
        {
            if (id != model.BusinessID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    businessRepository.UpdateBusiness(id, RestaurantWithUploadedFile(model));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BusinessExists(model.BusinessID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Pulps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var business = businessRepository.GetDetails(id);
            if (business == null)
            {
                return NotFound();
            }

            return View(business);
        }

        // POST: Pulps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            businessRepository.DeleteBusinesses(id);
            return RedirectToAction("Index", "Businesses");
        }

        private bool BusinessExists(int id)
        {
            return businessRepository.BusinessExists(id);
        }

    }
}
