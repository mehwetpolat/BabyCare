using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
