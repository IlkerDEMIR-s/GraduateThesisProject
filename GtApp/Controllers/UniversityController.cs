using Entitites.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace GtApp.Controllers
{
    public class UniversityController : Controller
    {
        private readonly IServiceManager _manager;

        public UniversityController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<University> Index()
        {
            return _manager.UniversityService.GetAllUniversities(false);
        }
    }
}
