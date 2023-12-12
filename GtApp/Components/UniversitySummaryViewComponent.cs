using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace GtApp.Components
{
    public class UniversitySummaryViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public UniversitySummaryViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public string Invoke()
        {
            return _manager
                .UniversityService
                .GetAllUniversities(false)
                .Count()
                .ToString();
        }
    }
}