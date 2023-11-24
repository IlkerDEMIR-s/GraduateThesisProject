using Entitites.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace GtApp.Controllers
{
    public class InstituteController : Controller
    {
        private readonly IServiceManager _manager;

        public InstituteController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Institute> Index()
        {
            return _manager.InstituteService.GetAllInstitutes(false);
        }
    }
}
