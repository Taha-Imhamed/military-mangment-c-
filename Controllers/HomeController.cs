using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        
        public IActionResult Index(string username, string password)
        {
            if (username == "admin" && password == "adminpass")
            {
                return RedirectToAction("Privacy"); // Redirect to the admin page
            }
            else if (username == "soldier" && password == "soldierpass")
            {
                return RedirectToAction("soldier"); // Redirect to the soldier page
            }
            else if (username == "sargent" && password == "sargentpass")
            {
                return RedirectToAction("sargent"); // Redirect to the sergeant page
            }
            else
            {
                ViewBag.Error = "Invalid credentials. Please try again.";
                return View();
            }
        }


        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult soldier()
        {
            return View();
        }

        public IActionResult sargent()
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
