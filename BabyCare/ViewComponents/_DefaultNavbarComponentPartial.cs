using Microsoft.AspNetCore.Mvc;

namespace BabyCare.ViewComponents
{
    public class _DefaultNavbarComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
