using BabyCare.Context;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.ViewComponents
{
    public class _DefaultServiceComponentPartial : ViewComponent
    {
        private readonly BabyCareContext _context;

        public _DefaultServiceComponentPartial(BabyCareContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Services.ToList();
            return View(values);
        }
    }
}
