using BabyCare.Context;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly BabyCareContext _context;

        public DashboardController(BabyCareContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.personelSayisi = _context.Teams.Count();
            return View();
        }
    }
}
