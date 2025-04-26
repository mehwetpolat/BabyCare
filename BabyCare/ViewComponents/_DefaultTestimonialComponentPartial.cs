using BabyCare.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BabyCare.ViewComponents
{
    public class _DefaultTestimonialComponentPartial: ViewComponent
    {
        private readonly BabyCareContext _context;

        public _DefaultTestimonialComponentPartial(BabyCareContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Testimonials.ToList();
            return View(values);
        }
    }
}
