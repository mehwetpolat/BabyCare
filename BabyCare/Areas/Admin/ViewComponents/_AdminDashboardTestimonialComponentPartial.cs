using BabyCare.Context;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Areas.Admin.ViewComponents
{
    public class _AdminDashboardTestimonialComponentPartial: ViewComponent
    {
        private readonly BabyCareContext _context;

        public _AdminDashboardTestimonialComponentPartial(BabyCareContext context)
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
