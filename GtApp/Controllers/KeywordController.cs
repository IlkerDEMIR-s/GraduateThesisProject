using Entitites.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace GtApp.Controllers
{
    public class KeywordController : Controller
    {
        private readonly IServiceManager _manager;

        public KeywordController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Keyword> Index()
        {
            return _manager.KeywordService.GetAllKeywords(false);
        }
    }
}
