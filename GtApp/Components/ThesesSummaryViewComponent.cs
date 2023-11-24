using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace GtApp.Components
{
    public class ThesesSummaryViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public ThesesSummaryViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public string Invoke()
        {
            var numberOfTheses = _manager.ThesisService.GetAllTheses(false).Count().ToString();
            return $"{numberOfTheses}";
        }
    }
}
