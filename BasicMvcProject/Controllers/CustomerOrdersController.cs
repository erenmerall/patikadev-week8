using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BasicMvcProject.Models;
using System.Collections.Generic;
using BasicMvcProject.ViewModels;

namespace BasicMvcProject.Controllers
{
    // [Route("[controller]")]
    public class CustomerOrdersController : Controller
    {
        private readonly ILogger<CustomerOrdersController> _logger;

        public CustomerOrdersController(ILogger<CustomerOrdersController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            // Örnek müşteri
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Eren",
                LastName = "Meral",
                Email = "erenmeral02@gmail.com"
            };

            // Örnek siparişler
            var orders = new List<Order>
            {
                new Order { Id = 1, ProductName = "Laptop", Price = 15000 },
                new Order { Id = 2, ProductName = "Mouse", Price = 300 },
                new Order { Id = 3, ProductName = "Klavye", Price = 700 }
            };

            // ViewModel oluşturuluyor
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
