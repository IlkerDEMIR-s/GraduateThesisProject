using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace GtApp.Components
{
    public class TypeMenuViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public TypeMenuViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public IViewComponentResult Invoke()
        {
            var types = _manager.ThesisTypeService.GetAllThesisTypes(false);
            return View(types);
        }
    }
}
