using BabyCare.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BabyCare.Areas.Admin.ViewComponents
{
    public class _AdminDashboardTeacherComponentPartial: ViewComponent
    {
        private readonly BabyCareContext _context;

        public _AdminDashboardTeacherComponentPartial(BabyCareContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Teams.Include(x => x.Branch).ToList();
            return View(values);
        }
    }
}
