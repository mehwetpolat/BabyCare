using BabyCare.Context;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.ViewComponents
{
    public class _DefaultEventComponentPartial: ViewComponent
    {
        private readonly BabyCareContext _context;

        public _DefaultEventComponentPartial(BabyCareContext context)
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
