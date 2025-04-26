using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
