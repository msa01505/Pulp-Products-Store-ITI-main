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
using Pulp.ViewModels;

namespace Pulp.Controllers
{
    public class OrderItemsController : Controller
    {
        private readonly IOrderItemsRepoService orderItemsRepoService;
        private readonly ICategoryItemRepoService categoryItemsRepoService;
        private readonly ICategoryTypeRepoService categoryTypeRepoService;
        private readonly IOrderRepoService orderRepoService;
        private readonly IBuyerRepoService buyerRepoService;
        private readonly UserManager<PulpProjectUser> UserManager;


        public OrderItemsController(IOrderItemsRepoService _orderItemsRepoService,
            ICategoryItemRepoService _categoryItemsRepoService,
            ICategoryTypeRepoService _categoryTypeRepoService,
            IOrderRepoService _orderRepoService,
            IBuyerRepoService _buyerRepoService,
            UserManager<PulpProjectUser> _userManager)
        {
            orderItemsRepoService = _orderItemsRepoService;
            categoryItemsRepoService = _categoryItemsRepoService;
            categoryTypeRepoService = _categoryTypeRepoService;
            orderRepoService = _orderRepoService;
            buyerRepoService = _buyerRepoService;
            UserManager = _userManager;

        }

        // GET: OrderItems

        public async Task<IActionResult> Index()
        {

            return View(orderItemsRepoService.GetAllOrderItemss());
        }

        // GET: OrderItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderItem = orderItemsRepoService.GetDetails(id);
            if (orderItem == null)
            {
                return NotFound();
            }

            return View(orderItem);
        }

        // GET: OrderItems/Create
        [Authorize]
        public IActionResult Create(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CategoryItem ct = categoryItemsRepoService.GetDetails(id);
            if (ct != null)
            {

                OrderItemCategoryItem current = new OrderItemCategoryItem()
                {
                    categoryItem = ct,
                    orderItem = new OrderItem(),
                    ResID = categoryTypeRepoService.GetBusinessID(ct.CategoryTypeId)



                };
                current.orderItem.Units = 0;
                return View(current);
            }
            else
            {
                return RedirectToAction("Details", "Businesses", new { id = categoryTypeRepoService.GetBusinessID(id) });
            }
            //CategoryItem current = this.categoryItemsRepoService.GetDetails(categoryItemID);
            // ViewData["CategoryItemID"] = new SelectList(this.categoryItemsRepoService.GetAllCategoryItems(), "CategoryItemID", "Description");
            // ViewData["CategoryItemID"] = current;
            //TempData["CategoryItemID"] = current;
            //TempData.Peek("CategoryItemID")
            // return View(current);
        }

        // POST: OrderItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderItemID,CategoryItemID,Price,Units")] OrderItem orderItem)
        {
            Order order = new Order();
            if (orderItem.Units < 1)
            {
                ModelState.AddModelError("units", "please choose unit");
            }
            CategoryItem ct = categoryItemsRepoService.GetDetails(orderItem.CategoryItemID);
            OrderItemCategoryItem temp = new OrderItemCategoryItem()
            {
                categoryItem = ct,
                orderItem = orderItem,
                ResID = categoryTypeRepoService.GetBusinessID(ct.CategoryTypeId)
            };
            if (ModelState.IsValid)
            {
                Buyer currentBuyer = buyerRepoService.GetBuyerByUsername(UserManager.GetUserName(User));

                //check in list for all items of this user with same type if exists instead of inserting add to the quantity
                var userOrders= orderRepoService.GetAllOrdersOfUserID(currentBuyer.UserID);
                Order waitingOrder = null;
                //bool foundOneWaitingOrder = false;
                foreach(Order o in userOrders)
                {
                    if(o.orderStatus == OrderStatus.Initial)
                    {
                        waitingOrder = o;
                        //break;
                    }
                }
                OrderItem previouslyExistingOrderItem = null;

                foreach(OrderItem item in waitingOrder?.OrderItems??new List<OrderItem>())
                {
                    if(item.CategoryItemID == orderItem.CategoryItemID)
                    {
                        previouslyExistingOrderItem = item;
                    }
                }
                if (previouslyExistingOrderItem == null)
                {

                    order.OrderID = 0;
                    order.BuyerID = currentBuyer.UserID;
                    order.OrderDate = DateTime.Now;




                    order.orderStatus = OrderStatus.Initial;
                    int orderID = orderRepoService.Insert(order);
                    orderItem.OrderID = orderID;
                    orderItemsRepoService.Insert(orderItem);
                   

                }
                else //instead of inserting order item and order we'll just edit the existing order item and update it in the db
                {
                    previouslyExistingOrderItem.Units += orderItem.Units;
                    orderRepoService.UpdateOrder(waitingOrder.OrderID, waitingOrder);
                    orderItemsRepoService.UpdateOrderItems(previouslyExistingOrderItem.OrderItemID,previouslyExistingOrderItem);
                    
                }
                int? resID = categoryTypeRepoService.GetBusinessID(categoryItemsRepoService.GetDetails(orderItem.CategoryItemID).CategoryTypeId);
                return RedirectToAction("Details", "Businesses", new { id = resID });



            }
            return View(temp);
        }

        // GET: OrderItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderItem = orderItemsRepoService.GetDetails(id);
            if (orderItem == null)
            {
                return NotFound();
            }
            ViewData["CategoryItemID"] = new SelectList(categoryItemsRepoService.GetAllCategoryItems(), "CategoryItemID", "Description", orderItem.CategoryItemID);
            return View(orderItem);
        }

        // POST: OrderItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderItemID,CategoryItemID,Price,Units")] OrderItem orderItem)
        {
            if (id != orderItem.OrderItemID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    orderItemsRepoService.UpdateOrderItems(id, orderItem);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderItemExists(orderItem.OrderItemID))
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
            ViewData["CategoryItemID"] = new SelectList(categoryItemsRepoService.GetAllCategoryItems(), "CategoryItemID", "Description", orderItem.CategoryItemID);
            return View(orderItem);
        }

        // GET: OrderItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderItem = orderItemsRepoService.GetDetails(id);
            if (orderItem == null)
            {
                return NotFound();
            }


            return View(orderItem);
        }

        // POST: OrderItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            OrderItem orderitem = orderItemsRepoService.GetDetails(id);
            orderItemsRepoService.DeleteOrderItems(id);

            orderRepoService.DeleteOrder(orderitem.OrderID);
            return RedirectToAction("Index", "Orders");
        }

        private bool OrderItemExists(int id)
        {
            return orderItemsRepoService.OrderItemsExists(id);
        }
    }
}
