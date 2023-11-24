using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace StoreApp.Components
{
    public class SubjectTopicMenuViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public SubjectTopicMenuViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public IViewComponentResult Invoke()
        {
            var topics = _manager.SubjectTopicService.GetAllSubjectTopics(false);
            return View(topics);
        }
    }
}