using BabyCare.Context;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Areas.Admin.ViewComponents
{
    public class _AdminDashboardEventComponentPartial : ViewComponent
    {
        private readonly BabyCareContext _context;

        public _AdminDashboardEventComponentPartial(BabyCareContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Events.ToList();
            return View(values);
        }
    }
}
