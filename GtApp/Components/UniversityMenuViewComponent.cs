using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace GtApp.Components
{
    public class UniversityMenuViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public UniversityMenuViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public IViewComponentResult Invoke()
        {
            var universities = _manager.UniversityService.GetAllUniversities(false);
            return View(universities);
        }
    }
}