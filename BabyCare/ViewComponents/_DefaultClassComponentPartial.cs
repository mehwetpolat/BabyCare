using BabyCare.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BabyCare.ViewComponents
{
    public class _DefaultClassComponentPartial : ViewComponent
    {
        private readonly BabyCareContext _context;

        public _DefaultClassComponentPartial(BabyCareContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Classes.Include(x => x.Team).ToList();
            return View(values);
        }
    }
}
