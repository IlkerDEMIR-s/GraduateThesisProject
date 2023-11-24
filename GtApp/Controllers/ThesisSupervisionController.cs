using Entitites.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace GtApp.Controllers
{
    public class ThesisSupervisionController : Controller
    {
        private readonly IServiceManager _manager;

        public ThesisSupervisionController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<ThesisSupervision> Index()
        {
            return _manager.ThesisSupervisionService.GetAllThesisSupervisions(false);
        }
    }
}
