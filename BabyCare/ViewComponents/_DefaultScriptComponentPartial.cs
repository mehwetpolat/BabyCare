using Microsoft.AspNetCore.Mvc;

namespace BabyCare.ViewComponents
{
    public class _DefaultScriptComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
