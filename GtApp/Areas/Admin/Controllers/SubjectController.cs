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
    public class SubjectController : Controller
    {
        private readonly IServiceManager _manager;

        public SubjectController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Subject Topics";
            var subjectTopicModel = _manager.SubjectTopicService.GetAllSubjectTopics(false).ToList();

            return View(subjectTopicModel);
        }

        public IActionResult Create()
        {
            ViewData["Title"] = "Create";
            TempData["info"] = "Please fill the form.";

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] SubjectTopic subjectTopic)
        {
            if (ModelState.IsValid)
            {
                var newSubjectTopic = new SubjectTopic
                {
                    SUBJECT_TOPIC_CONTENT = subjectTopic.SUBJECT_TOPIC_CONTENT
                };

                _manager.SubjectTopicService.CreateSubjectTopic(newSubjectTopic);

                TempData["info"] = $"Subject '{newSubjectTopic.SUBJECT_TOPIC_CONTENT}' created successfully.";
                return RedirectToAction("Index");
            }

            return View();

        }

        [HttpGet]
        public IActionResult Delete([FromRoute(Name = "id")] int id)
        {
            _manager.SubjectTopicService.DeleteSubjectTopic(id);

            TempData["Danger"] = $"Subject deleted successfully.";
            return RedirectToAction("Index");
        }
    }
}