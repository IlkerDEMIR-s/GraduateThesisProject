using Entitites.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace GtApp.Controllers
{
    public class SupervisorController : Controller
    {
        private readonly IServiceManager _manager;

        public SupervisorController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Supervisor> Index()
        {
            return _manager.SupervisorService.GetAllSupervisors(false);
        }
    }
}
