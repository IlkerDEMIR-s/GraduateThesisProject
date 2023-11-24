using Entitites.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;
using Services.Contracts;

namespace GtApp.Controllers
{
    public class SubjectTopicController:Controller
    {
        private readonly IServiceManager _manager;

        public SubjectTopicController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<SubjectTopic> Index()
        {
            return _manager.SubjectTopicService.GetAllSubjectTopics(false);
        }
    }
}
