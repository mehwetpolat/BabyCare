using BabyCare.Context;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeamController : Controller
    {
        private readonly BabyCareContext _context; 

        public TeamController(BabyCareContext context)
        {
            _context = context;
        }

        public IActionResult TeamList()
        {
            var values = _context.Teams.ToList();
            return View(values);
        }
    }
}