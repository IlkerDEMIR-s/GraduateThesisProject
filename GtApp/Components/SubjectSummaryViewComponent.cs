using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace GtApp.Components
{
    public class SubjectSummaryViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public SubjectSummaryViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public string Invoke()
        {
            return _manager
                        .SubjectTopicService
                        .GetAllSubjectTopics(false)
                        .Count()
                        .ToString();
        }
    }
}