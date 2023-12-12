using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using Entitites.ViewModels;
using Entitites.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GtApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TypeController : Controller
    {
        private readonly IServiceManager _manager;

        public TypeController(IServiceManager manager)
        {
            _manager = manager;
        }



        public IActionResult Index()
        {
            ViewData["Title"] = "Types";
            var typesModel = _manager.ThesisTypeService.GetAllThesisTypes(false).ToList();

            return View(typesModel);
        }

        public IActionResult Create()
        {
            ViewData["Title"] = "Create";
            TempData["info"] = "Please fill the form.";

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] ThesisType type)
        {
            if (ModelState.IsValid)
            {
                var newType = new ThesisType
                {
                    TYPE_NAME = type.TYPE_NAME
                };

                _manager.ThesisTypeService.CreateThesisType(newType);

                TempData["info"] = $"Type {newType.TYPE_NAME} created successfully.";
                return RedirectToAction("Index");
            }

            return View();

        }


        [HttpGet]
        public IActionResult Delete([FromRoute(Name = "id")] int id)
        {
            _manager.ThesisTypeService.DeleteOneThesisType(id);

            TempData["Danger"] = $"Type deleted successfully.";
            return RedirectToAction("Index");
        }
    }
}