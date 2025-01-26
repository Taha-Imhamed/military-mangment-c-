using Microsoft.AspNetCore.Mvc;

namespace WebApplication12.Controllers
{
    public interface IHomeController
    {
        IActionResult Error();
        IActionResult Index();
        IActionResult Privacy();
        IActionResult sargent();
        IActionResult soldier();
    }
}