using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using Entitites.ViewModels;
using Entitites.Models;
using Entities.RequestParameters;

namespace GtApp.Controllers
{
    public class ThesisController : Controller
    {
        private readonly IServiceManager _manager;

        public ThesisController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index(ThesisRequestParameters t)
        {
            ViewData["Title"] = "Theses";
            var theses = _manager.ThesisService.GetAllThesesWithDetails(t).ToList();
            var thesisViewModels = new List<ThesisViewModel>();

            foreach (var thesis in theses)
            {
                var authorship = _manager.thesisAuthorshipService.GetOneThesisAuthorship((int)thesis.THESIS_NO, false);
                var author = authorship != null ? _manager.AuthorService.GetOneAuthor(authorship.AUTHOR_ID, false) : null;

                var thesisType = _manager.ThesisTypeService.GetOneThesisType((int)thesis.TYPE_ID, false);

                var thesisSubjectTopics = _manager.ThesisSubjectTopicService.GetAllThesisSubjectTopics(false)
                    .Where(thesisTopic => thesis.THESIS_NO == thesisTopic.THESIS_NO)
                    .ToList();

                var subjectTopics = thesisSubjectTopics
                    .Select(thesisTopic => _manager.SubjectTopicService.GetOneSubjectTopic(thesisTopic.SUBJECT_TOPIC_ID, false))
                    .ToList();

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




        public IActionResult Get([FromRoute(Name = "id")] int thesis_no)
        {
            var thesis = _manager.ThesisService.GetOneThesis(thesis_no, false);
            ViewData["Title"] = thesis?.THESIS_NO;

            var thesisAuthorship = _manager.thesisAuthorshipService.GetOneThesisAuthorship(thesis_no, false);
            Author? author = null;

            if (thesisAuthorship != null)
            {
                var authorId = thesisAuthorship.AUTHOR_ID;
                author = _manager.AuthorService.GetOneAuthor(authorId, false);
            }

            University? university = null;
            var universityId = thesis.UNIVERSITY_ID;
            university = _manager.UniversityService.GetOneUniversity(universityId, false) ?? new University();

            ThesisType? thesisType = null;
            var thesisTypeId = thesis.TYPE_ID;
            thesisType = _manager.ThesisTypeService.GetOneThesisType(thesisTypeId, false) ?? new ThesisType();

            Institute? institute = null;
            var instituteId = thesis.INSTITUTE_ID;
            institute = _manager.InstituteService.GetOneInstitute(instituteId, false) ?? new Institute();

            // Fetch all SubjectTopics for the thesis
            var thesisSubjectTopics = _manager.ThesisSubjectTopicService.GetAllThesisSubjectTopics(false)
                .Where(thesisTopic => thesis_no == thesisTopic.THESIS_NO)
                .ToList();

            // Fetch all SubjectTopics
            var subjectTopics = thesisSubjectTopics
                .Select(thesisTopic => _manager.SubjectTopicService.GetOneSubjectTopic(thesisTopic.SUBJECT_TOPIC_ID, false))
                .ToList();

            // Fetch all Keywords
            var keywords = _manager.KeywordService.GetAllKeywords(false)
                    .Where(thesisKeyword => thesis.THESIS_NO == thesisKeyword.THESIS_NO)
                    .ToList();

            // Fetch supervisor and co-supervisor
            var thesisSupervision = _manager.ThesisSupervisionService.GetOneThesisSupervision(thesis_no, false);
            var supervisor = thesisSupervision != null ? _manager.SupervisorService.GetOneSupervisor(thesisSupervision.SUPERVISOR_ID, false) : null;
            var coSupervisor = thesisSupervision != null && thesisSupervision.CO_SUPERVISOR_ID != null ? _manager.SupervisorService.GetOneSupervisor((int)thesisSupervision.CO_SUPERVISOR_ID, false) : null;

            var viewModel = new ThesisViewModel
            {
                Thesis = thesis,
                Author = author,
                University = university,
                Institute = institute,
                SubjectTopics = subjectTopics,
                Supervisor = supervisor,
                CoSupervisor = coSupervisor,
                Keywords = keywords,
                ThesisType = thesisType
            };

            return View(viewModel);
        }

    }
}
