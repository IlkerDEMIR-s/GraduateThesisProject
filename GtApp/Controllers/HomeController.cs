using Microsoft.AspNetCore.Mvc;

namespace GtApp.Controllers{

    public class HomeController : Controller{
        public IActionResult Index(){
            ViewData["Title"] = "Welcome";
            return View();
        }
    }
  
}