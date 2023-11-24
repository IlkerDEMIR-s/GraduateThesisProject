using Entitites.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;
using Services.Contracts;

namespace GtApp.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IServiceManager _manager;

        public AuthorController(IServiceManager manager)
        {
            _manager = manager;
        }


        public IEnumerable<Author> Index()
        {
            return _manager.AuthorService.GetAllAuthors(false);
        }
    }
}
