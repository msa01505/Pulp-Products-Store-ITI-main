using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pulp.Models;
using Pulp.Services;
using Pulp.ViewModels;

namespace Pulp.Controllers
{
    public class CategoryTypesController : Controller
    {
        private readonly ICategoryTypeRepoService categoryTypeRepoService;
        private readonly IBusinessRepoService businessRepoService;
        public CategoryTypesController(ICategoryTypeRepoService _categoryTypeRepoService, IBusinessRepoService _businessRepoService)
        {
            categoryTypeRepoService = _categoryTypeRepoService;
            businessRepoService = _businessRepoService;
        }

        // GET: CategoryTypes
        public async Task<IActionResult> Index()
        {
            return View(categoryTypeRepoService.GetAllCategoryTypes());
        }

        // GET: CategoryTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryType = categoryTypeRepoService.GetDetails(id);
            if (categoryType == null)
            {
                return NotFound();
            }

            return View(categoryType);
        }

        // GET: CategoryTypes/Create
        public IActionResult Create(int? id)
        {
            
            if (id == null)
            {
                return NotFound();
            }
            Business curr = businessRepoService.GetDetails(id);
            if (curr != null)
            {
                BusinessCategoryType businessCategory = new BusinessCategoryType()
                {
                    business = curr

                };
                //TempData["BusinessID"] = curr;
                //TempData.Keep();
                return View(businessCategory);

            }
            else
            {
                return RedirectToAction("Details", "Businesses", new { id });
            }
        }

        // POST: CategoryTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BusinessCategoryType businessCategory)
        {
            CategoryType categoryType = new CategoryType()
            {
                Type = businessCategory.categoryType.Type,
                BusinessID = businessCategory.business.BusinessID,

            };

            if (businessRepoService.BusinessExists(categoryType.BusinessID) && categoryType.Type != null)
            {
                categoryTypeRepoService.Insert(categoryType);
                return RedirectToAction("Details", "Businesses", new { id = categoryType.BusinessID });
            }
            return View(businessCategory);
        }

        // GET: CategoryTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryType = categoryTypeRepoService.GetDetails(id);
            if (categoryType == null)
            {
                return NotFound();
            }
            return View(categoryType);
        }

        // POST: CategoryTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CatrgoryTypeID,Type,BusinessID")] CategoryType categoryType)
        {
            if (id != categoryType.CatrgoryTypeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    categoryTypeRepoService.UpdateCategoryType(id, categoryType);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryTypeExists(categoryType.CatrgoryTypeID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Businesses", new { id = categoryType.BusinessID });
            }
            return View(categoryType);
        }

        // GET: CategoryTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryType = categoryTypeRepoService.GetDetails(id);
            if (categoryType == null)
            {
                return NotFound();
            }

            return View(categoryType);
        }

        // POST: CategoryTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            int tempID = categoryTypeRepoService.GetDetails(id).BusinessID;
            categoryTypeRepoService.DeleteCategoryType(id);
            return RedirectToAction("Details", "Businesses", new { id = tempID });
        }

        private bool CategoryTypeExists(int id)
        {
            return categoryTypeRepoService.CategoryTypeExists(id);
        }
    }
}
