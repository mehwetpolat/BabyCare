using BabyCare.Context;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminDefaultController : Controller
    {
        private readonly BabyCareContext _context;

        public AdminDefaultController(BabyCareContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.messageCount = _context.Contacts.Count();
            return View();
        }
    }
}
