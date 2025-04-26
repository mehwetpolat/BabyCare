using BabyCare.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BabyCare.ViewComponents
{
    public class _DefaultTeamComponentPartial : ViewComponent
    {
        private readonly BabyCareContext _context;

        public _DefaultTeamComponentPartial(BabyCareContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Teams.Include(x => x.SocialMedias).Include(y =>y.Branch).ToList();
            return View(values);
        }
    }
}
