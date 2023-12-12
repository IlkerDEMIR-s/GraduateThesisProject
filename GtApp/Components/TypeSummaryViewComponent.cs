using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace GtApp.Components
{
    public class TypeSummaryViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public TypeSummaryViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public string Invoke()
        {
            return _manager
                        .ThesisTypeService
                        .GetAllThesisTypes(false)
                        .Count()
                        .ToString();
        }
    }
}