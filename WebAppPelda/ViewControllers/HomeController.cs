using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAppPelda.Controllers;
using WebAppPelda.Models;

namespace WebAppPelda.ViewControllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult CustomerList() {
            List<Customer> customers = new CustomerController().GetCustomersFromDatabase();
            return View(customers);
        }
        public IActionResult SubPage()
        {
            Customer customer = new Customer
            {
                Id = 1,
                Name = "Test",
                Phone = "123-455",
                Score = 1,
            };
            return View(customer);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
