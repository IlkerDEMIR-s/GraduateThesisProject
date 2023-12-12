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
    public class UniversityController : Controller
    {
        private readonly IServiceManager _manager;

        public UniversityController(IServiceManager manager)
        {
            _manager = manager;
        }



        public IActionResult Index()
        {
            ViewData["Title"] = "Universities";
            var universityModel = _manager.UniversityService.GetAllUniversities(false).ToList();

            return View(universityModel);
        }

        public IActionResult Create()
        {
            ViewData["Title"] = "Create";
            TempData["info"] = "Please fill the form.";

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] UniversityAndInstituteViewModel universityModel)
        {
           var university = universityModel.University;
            var institute = universityModel.Institute;

            if (ModelState.IsValid)
            {
                var newUniversity = new University
                {
                    UNIVERSITY_NAME = university.UNIVERSITY_NAME
                };

                _manager.UniversityService.CreateUniversity(newUniversity);

                if(universityModel.EnteredInstitutes != null && universityModel.EnteredInstitutes.Count > 0)
                {
                    foreach (var instituteText in universityModel.EnteredInstitutes)
                    {
                         if(!string.IsNullOrEmpty(instituteText))
                         {
                             var newInstitute = new Institute
                             {
                                 INSTITUTE_NAME = instituteText,
                                 UNIVERSITY_ID = newUniversity.UNIVERSITY_ID
                             };

                             _manager.InstituteService.CreateInstitute(newInstitute);
                         }
                    }
                }

                TempData["info"] = $"University {newUniversity.UNIVERSITY_NAME} created successfully.";
                return RedirectToAction("Index");
            }

            return View();

        }

        [HttpGet]
        public IActionResult Delete([FromRoute(Name = "id")] int id)
        {
            _manager.InstituteService.DeleteInstitutesByUniversityId(id);
            _manager.UniversityService.DeleteUniversity(id);
        
            TempData["Danger"] = $"University deleted successfully.";
            return RedirectToAction("Index");
        }
    }
}