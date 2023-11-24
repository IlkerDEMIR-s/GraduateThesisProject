using Entitites.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace GtApp.Controllers
{
    public class ThesisSubjectTopicController : Controller
    {
        private readonly IServiceManager _manager;

        public ThesisSubjectTopicController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<ThesisSubjectTopic> Index()
        {
            return _manager.ThesisSubjectTopicService.GetAllThesisSubjectTopics(false);
        }
    }
}
