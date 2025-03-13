using BabyCare.Context;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.ViewComponents
{
    public class _DefaultAboutComponentPartial:ViewComponent
    {
        private readonly BabyCareContext _context;

        public _DefaultAboutComponentPartial(BabyCareContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Abouts.ToList();
            return View(values);
        }
    }
}
