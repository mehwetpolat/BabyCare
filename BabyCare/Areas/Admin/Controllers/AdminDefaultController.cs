using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminDefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
