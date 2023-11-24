using Entitites.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;
using Services.Contracts;

namespace GtApp.Controllers
{
    public class ThesisTypeController : Controller
    {
        private readonly IServiceManager _manager;

        public ThesisTypeController(IServiceManager manager)
        {
            _manager = manager;
        }


        public IEnumerable<ThesisType> Index()
        {
            return _manager.ThesisTypeService.GetAllThesisTypes(false);
        }
    }
}
