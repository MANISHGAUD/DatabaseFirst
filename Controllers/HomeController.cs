using DataBaseFirstApporach.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DataBaseFirstApporach.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BikeStoreContext context;

        public HomeController(ILogger<HomeController> logger , BikeStoreContext context )
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Brand() {
            return View(context.Brands.ToList());        
        }

        public IActionResult Category()
        {
            return View(context.Categories.ToList());
           
        }
        public IActionResult Customer() 
        {
            return View(context.Customers.ToList());        
        }
        public IActionResult Product()
        {
            return View(context.Products.ToList());
        }
        public IActionResult Order()
        {
            return View(context.Orders.ToList());
        }
        public IActionResult OrderItem()
        {
            return View(context.OrderItems.ToList());
        }
        public IActionResult Staff() 
        {
            return View(context.Staffs.ToList());
        }
        public IActionResult Stock() 
        {
            return View(context.Stocks.ToList());
        }
        public IActionResult Store() 
        {
            return View(context.Stores.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}