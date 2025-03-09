using Microsoft.AspNetCore.Mvc;

namespace BabyCare.ViewComponents
{
    public class _DefaultHeadComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }


    }
}
