using Microsoft.AspNetCore.Mvc;

namespace GtApp.Components
{
    public class ThesisFilterMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}