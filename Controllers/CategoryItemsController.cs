using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pulp.Models;
using Pulp.Services;
using Pulp.ViewModels;

namespace Pulp.Controllers
{
    public class CategoryItemsController : Controller
    {
        private readonly ICategoryItemRepoService categoryItemRepoService;
        private readonly ICategoryTypeRepoService categoryTypeRepoService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public CategoryItemsController(ICategoryItemRepoService _categoryItemRepoService,
            ICategoryTypeRepoService _categoryTypeRepoService, IWebHostEnvironment _webHostEnvironment)
        {
            categoryItemRepoService = _categoryItemRepoService;
            categoryTypeRepoService = _categoryTypeRepoService;
            webHostEnvironment = _webHostEnvironment;
        }

        // GET: CategoryItems
        public async Task<IActionResult> Index()
        {

            return View(categoryItemRepoService.GetAllCategoryItems());
        }

        // GET: CategoryItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryItem = categoryItemRepoService.GetDetails(id);
            if (categoryItem == null)
            {
                return NotFound();
            }

            return View(categoryItem);
        }

        // GET: CategoryItems/Create
        public IActionResult Create(int? id)
        {
            ViewData["CategoryTypeId"] = categoryTypeRepoService.GetDetails(id);
            ViewData["ResID"] = categoryTypeRepoService.GetBusinessID(id);


            //new SelectList(this.categoryTypeRepoService.GetAllCategoryTypes(), "CatrgoryTypeID", "Type",new {CategoryTypeID=id});
            return View();
        }

        private CategoryItem CategoryItemWithUploadedFile(CategoryItemViewModel model)
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
                uniqueFileName = model.Description.Replace(" ", string.Empty) + Path.GetExtension(model.Image.FileName);
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                // Use CopyTo() method provided by IFormFile interface to
                // copy the file to wwwroot/images folder
                model.Image.CopyTo(new FileStream(filePath, FileMode.Create));
            }


            CategoryItem categoryItem = new CategoryItem
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                // Store the file name in PhotoPath property of the employee object
                // which gets saved to the Employees database table
                PictureUri = uniqueFileName,

            };

            return categoryItem;
        }

        // POST: CategoryItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CategoryItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                CategoryItem temp = CategoryItemWithUploadedFile(model);
                temp.CategoryTypeId = model.CategoryTypeId;
                categoryItemRepoService.Insert(temp);
                int? resID = categoryTypeRepoService.GetBusinessID(model.CategoryTypeId);
                return RedirectToAction("Details", "Businesses", new { id = resID });//get Pulp id
            }
            ViewData["CategoryTypeId"] = categoryTypeRepoService.GetDetails(model.CategoryTypeId);
            // ViewData["CategoryTypeId"] = new SelectList(this.categoryTypeRepoService.GetAllCategoryTypes(), "CatrgoryTypeID", "Type", categoryItem.CategoryTypeId);
            return View(model);
        }

        // GET: CategoryItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryItem = categoryItemRepoService.GetDetails(id);
            if (categoryItem == null)
            {
                return NotFound();
            }
            ViewData["CategoryTypeId"] = categoryTypeRepoService.GetDetails(categoryItem.CategoryTypeId);
            ViewData["ResID"] = categoryTypeRepoService.GetBusinessID(categoryItem.CategoryTypeId);

            //ViewData["CategoryTypeId"] = new SelectList(this.categoryTypeRepoService.GetAllCategoryTypes(), "CatrgoryTypeID", "Type", categoryItem.CategoryTypeId);
            CategoryItemViewModel model = new CategoryItemViewModel
            {
                CategoryItemID = categoryItem.CategoryItemID,
                Description = categoryItem.Description,
                Name = categoryItem.Name,
                CategoryTypeId = categoryItem.CategoryTypeId,
                Price = categoryItem.Price
            };
            return View(model);
        }

        // POST: CategoryItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CategoryItemViewModel model)
        {
            if (id != model.CategoryItemID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    CategoryItem temp = CategoryItemWithUploadedFile(model);
                    temp.CategoryTypeId = model.CategoryTypeId;
                    categoryItemRepoService.UpdateCategoryItem(id, temp);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryItemExists(model.CategoryItemID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                int? resID = categoryTypeRepoService.GetBusinessID(model.CategoryTypeId);

                return RedirectToAction("Details", "Businesses", new { id = resID });
            }
            ViewData["CategoryTypeId"] = categoryTypeRepoService.GetDetails(model.CategoryTypeId);

            // ViewData["CategoryTypeId"] = new SelectList(this.categoryTypeRepoService.GetAllCategoryTypes(), "CatrgoryTypeID", "Type", categoryItem.CategoryTypeId);
            return View(model);
        }

        // GET: CategoryItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryItem = categoryItemRepoService.GetDetails(id);
            if (categoryItem == null)
            {
                return NotFound();
            }

            


            int? resID = categoryTypeRepoService.GetBusinessID(categoryItemRepoService.GetDetails(id).CategoryTypeId);
            ViewData["ResID"] = resID;

            return View(categoryItem);
        }

        // POST: CategoryItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            int? resID = categoryTypeRepoService.GetBusinessID(categoryItemRepoService.GetDetails(id).CategoryTypeId);

            var categoryItem = categoryItemRepoService.GetDetails(id);
            if (categoryItem == null)
            {
                return NotFound();
            }

            //delete image of CategoryItem

            var directory = Path.Combine(webHostEnvironment.WebRootPath, "images");
            string[] filePaths = Directory.GetFiles(directory);
            var img = Path.Combine(webHostEnvironment.WebRootPath, "images", categoryItem.Description.Replace(" ", string.Empty));
            var imgPath = filePaths.Where(p => p.Contains(img)).FirstOrDefault();
         
            if (System.IO.File.Exists(imgPath))
            {
                System.IO.File.Delete(imgPath);
            }

            categoryItemRepoService.DeleteCategoryItem(id);

            //int tempID = this.categoryTypeRepoService.GetDetails(id).BusinessID;
            //  this.categoryTypeRepoService.DeleteCategoryType(id);
            //  return RedirectToAction("Details", "Pulps", new { id = tempID });
            return RedirectToAction("Details", "Businesses", new { id = resID });
        }

        private bool CategoryItemExists(int id)
        {


            return categoryItemRepoService.CategoryItemExists(id);
        }
    }
}
