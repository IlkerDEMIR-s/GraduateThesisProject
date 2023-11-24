using Entitites.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace GtApp.Controllers
{
    public class ThesisAuthorshipController : Controller
    {
        private readonly IServiceManager _manager;

        public ThesisAuthorshipController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<ThesisAuthorship> Index()
        {
            return _manager.thesisAuthorshipService.GetAllThesisAuthorships(false);
        }
    }
}
