using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using Entitites.ViewModels;
using Entitites.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GtApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ThesisController : Controller
    {
        private readonly IServiceManager _manager;

        public ThesisController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Theses";
            var theses = _manager.ThesisService.GetAllTheses(false).ToList();
            var thesisViewModels = new List<ThesisViewModel>();

            foreach (var thesis in theses)
            {
                var authorship = _manager.thesisAuthorshipService.GetOneThesisAuthorship((int)thesis.THESIS_NO, false);
                var author = authorship != null ? _manager.AuthorService.GetOneAuthor(authorship.AUTHOR_ID, false) : null;

                var thesisSubjectTopics = _manager.ThesisSubjectTopicService.GetAllThesisSubjectTopics(false)
                    .Where(thesisTopic => thesis.THESIS_NO == thesisTopic.THESIS_NO)
                    .ToList();

                var subjectTopics = thesisSubjectTopics
                    .Select(thesisTopic => _manager.SubjectTopicService.GetOneSubjectTopic(thesisTopic.SUBJECT_TOPIC_ID, false))
                    .ToList();

                var typeId = thesis.TYPE_ID;
                var thesisType = _manager.ThesisTypeService.GetOneThesisType(typeId, false);

                var viewModel = new ThesisViewModel
                {
                    Thesis = thesis,
                    Author = author,
                    SubjectTopics = subjectTopics,
                    ThesisType = thesisType
                };

                thesisViewModels.Add(viewModel);
            }

            return View(thesisViewModels);
        }
        public void LoadViewBags()
        {
            ViewBag.Universities = new SelectList(_manager.UniversityService.GetAllUniversities(false), "UNIVERSITY_ID", "UNIVERSITY_NAME");
            ViewBag.Institutes = new SelectList(new List<Institute>(), "INSTITUTE_ID", "INSTITUTE_NAME"); // Empty list initially
            ViewBag.Authors = new SelectList(_manager.AuthorService.GetAllAuthors(false), "AUTHOR_ID", "AUTHOR_NAME");
            ViewBag.SubjectTopics = new SelectList(_manager.SubjectTopicService.GetAllSubjectTopics(false), "SUBJECT_TOPIC_ID", "SUBJECT_TOPIC_CONTENT");
            ViewBag.ThesisTypes = new SelectList(_manager.ThesisTypeService.GetAllThesisTypes(false), "TYPE_ID", "TYPE_NAME");
        }

        public IActionResult Create()
        {
            ViewData["Title"] = "Create";

            LoadViewBags();

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] ThesisViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var thesis = viewModel.Thesis;
                var supervisor = viewModel.Supervisor;
                var coSupervisor = viewModel.CoSupervisor;  
                var subjectTopic = viewModel.SubjectTopic;

                _manager.ThesisService.CreateThesis(thesis);

                // Create thesis authorship
                var authorship = new ThesisAuthorship
                {
                    AUTHOR_ID = thesis.AUTHOR_ID,
                    THESIS_NO = thesis.THESIS_NO
                };

                _manager.thesisAuthorshipService.CreateThesisAuthorship(authorship);

                _manager.SupervisorService.CreateSupervisor(supervisor);

                

                if (coSupervisor.SUPERVISOR_NAME != null)
                {
                    _manager.SupervisorService.CreateSupervisor(coSupervisor);
                }
                else { coSupervisor = null;}

                // Create thesis supervision
                var supervision = new ThesisSupervision
                {
                    THESIS_NO = thesis.THESIS_NO,
                    SUPERVISOR_ID = supervisor.SUPERVISOR_ID,  // Use the ID of the newly created supervisor
                    CO_SUPERVISOR_ID = coSupervisor?.SUPERVISOR_ID
                };

                _manager.ThesisSupervisionService.CreateThesisSupervision(supervision); 

                // Create thesis subject topics
                var thesisSubjectTopics = new ThesisSubjectTopic
                {
                    THESIS_NO = thesis.THESIS_NO,
                    SUBJECT_TOPIC_ID = subjectTopic.SUBJECT_TOPIC_ID
                };

                _manager.ThesisSubjectTopicService.CreateThesisSubjectTopic(thesisSubjectTopics);

                if (viewModel.EnteredKeywords != null && viewModel.EnteredKeywords.Any())
                {
                    foreach (var keywordText in viewModel.EnteredKeywords)
                    {
                        // Check if keywordText is not null or empty before creating a Keyword entity
                        if (!string.IsNullOrEmpty(keywordText))
                        {
                            var keyword = new Keyword
                            {
                                THESIS_NO = thesis.THESIS_NO,
                                KEYWORD = keywordText
                            };
                
                            _manager.KeywordService.CreateKeyword(keyword);
                        }
                    }
                }


                return RedirectToAction("Index");
            }       
                // Manually add a model error for SupervisorName
            ModelState.AddModelError(nameof(viewModel.Supervisor.SUPERVISOR_NAME), "Supervisor name is required.");
            ModelState.AddModelError(nameof(viewModel.SubjectTopicId), "Subject is required.");
            ModelState.AddModelError(nameof(viewModel.ThesisYear), "Thesis year is required.");
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            LoadViewBags();
             return View(viewModel);

        }


        [HttpGet]
        public IActionResult GetInstitutes(int universityId)
        {
            var institutes = _manager.InstituteService.GetAllInstitutes(false).Where(i => i.UNIVERSITY_ID == universityId).ToList();
            var instituteList = institutes.Select(i => new { value = i.INSTITUTE_ID, text = i.INSTITUTE_NAME }).ToList();

            return Json(instituteList);
        }


    }
}