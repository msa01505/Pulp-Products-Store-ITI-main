using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pulp.Areas.Identity.Data;
using Pulp.Models;
using Pulp.Services;

namespace Pulp.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly IReviewRepoService reviewRepoService;
        private readonly IBuyerRepoService buyerRepoService;
        private readonly UserManager<PulpProjectUser> UserManager;


        public ReviewsController(IReviewRepoService _reviewRepoService, IBuyerRepoService _buyerRepoService, UserManager<PulpProjectUser> _userManager)
        {
            reviewRepoService = _reviewRepoService;
            buyerRepoService = _buyerRepoService;
            UserManager = _userManager;
        }

        // GET: Reviews
        [Authorize(Roles ="Buyer")]
        public async Task<IActionResult> Index()
        {
            Buyer curr = buyerRepoService.GetBuyerByUsername(UserManager.GetUserName(User));

            ViewBag.currBuyer = curr.UserID;

            return View(reviewRepoService.GetAllReviews());
        }

        // GET: Reviews/Details/5
        [Authorize]

        public async Task<IActionResult> Details(int? id)
        {
            Buyer curr = buyerRepoService.GetBuyerByUsername(UserManager.GetUserName(User));

            ViewBag.currBuyer = curr.UserID;

            if (id == null)
            {
                return NotFound();
            }

            var review = reviewRepoService.GetDetails(id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        // GET: Reviews/Create
        [Authorize]

        public IActionResult Create()
        {
            
            return View();
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReviewID,Rating,Comment,UserID")] Review review)
        {
            if (ModelState.IsValid)
            {
                Buyer curr = buyerRepoService.GetBuyerByUsername(UserManager.GetUserName(User));
                review.BuyerID = curr.UserID;
                reviewRepoService.Insert(review);
                return RedirectToAction(nameof(Index));
            }
            return View(review);
        }

        // GET: Reviews/Edit/5
        [Authorize]

        public async Task<IActionResult> Edit(int? id)
        {
           
            if (id == null)
            {
                return NotFound();
            }

            var review = reviewRepoService.GetDetails(id);
            Buyer curr = buyerRepoService.GetBuyerByUsername(UserManager.GetUserName(User));

            if (review == null || curr.UserID != review.BuyerID)
            {
                return NotFound();
            }
            return View(review);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReviewID,Rating,Comment")] Review review)
        {

            if (id != review.ReviewID )
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    reviewRepoService.UpdateReview(id, review);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewExists(review.ReviewID))
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
            return View(review);
        }

        // GET: Reviews/Delete/5
        [Authorize]

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = reviewRepoService.GetDetails(id);
            Buyer curr = buyerRepoService.GetBuyerByUsername(UserManager.GetUserName(User));
            if (review == null || curr.UserID != review.BuyerID)
            {
                return NotFound();
            }

            return View(review);
        }
        [Authorize]

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            reviewRepoService.DeleteReview(id);
            return RedirectToAction(nameof(Index));
        }

        private bool ReviewExists(int id)
        {
            return reviewRepoService.ReviewExists(id);
        }
    }
}
