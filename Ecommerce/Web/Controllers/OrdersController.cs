using DataAccess;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ViewModels;

namespace Web.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ProductService _productService;
        private readonly UserManager<K102User> _userManager;
        private readonly ApplicationDbContext _context;
        public OrdersController(ApplicationDbContext context, UserManager<K102User> userManager)
        {
            _context = context;
            _productService = new ProductService(context);
            _userManager = userManager;
        }

        [Route("checkout")]
        [Authorize(Roles ="User")]
        public IActionResult CheckOut()
        {
            var cookieCart = Request.Cookies["cartItem"];
            if(cookieCart != null && cookieCart.Length>0)
            {
                List<int> productIds = cookieCart.Split('-').Select(x=>int.Parse(x)).ToList();
                var products = _productService.GetProductByIds(productIds);
                CheckoutVM vm = new CheckoutVM()
                {
                    Products = products,
                    ProductIDs = productIds,
                    K102Users=_userManager.GetUserAsync(User)
                };
                return View(vm);
            }
            return View();
        }


        [HttpPost]
        public IActionResult PlaceOrder(string Address,string PhoneNumber,string Description)
        {
            var cookieCart = Request.Cookies["cartItem"];
            if (cookieCart != null && cookieCart.Length > 0)
            {
                List<int> productIds = cookieCart.Split('-').Select(x => int.Parse(x)).ToList();
                var products = _productService.GetProductByIds(productIds);
                Task<K102User> currentUser = _userManager.GetUserAsync(User);
                Order newOrder = new()
                {
                   CustomerID=currentUser.Result.Id,
                   CustomerName=currentUser.Result.Firstname+" "+currentUser.Result.Lastname,
                   CustomerEmail=currentUser.Result.Email,
                   PhoneNumber=PhoneNumber,
                   Address=Address,
                   Description=Description,
                   OrderCode=Guid.NewGuid().ToString(),
                   OrderItems=new List<OrderItem>()
                };
                foreach (var pro in products)
                {
                    OrderItem orderItem = new()
                    {
                        ProductID=pro.ID,
                        ProductName=pro.Name,
                        Quantity=productIds.Where(x=>pro.ID==x).Count(),
                        itemPrice=pro.Price
                    };
                    newOrder.OrderItems.Add(orderItem);
                    newOrder.TotalAmmount=newOrder.OrderItems.Sum(x => (x.itemPrice * x.Quantity));
                    pro.Count -= newOrder.OrderItems.First(x => x.ProductID == pro.ID).Quantity;
                    newOrder.PlacedOn = DateTime.Now;
                    _context.Add(newOrder);
                    _context.SaveChangesAsync();
                    Response.Cookies.Delete("cartItem");
                }
               
            }

                return Json(null);
        }
    }
}
