using Services.Contracts;


namespace Services
{

    public class ServiceManager : IServiceManager
    {
        private readonly IThesisService _thesisService;
        private readonly ISubjectTopicService _subjectTopicService;
        private readonly IAuthorService _authorService;
        private readonly IThesisAuthorshipService _thesisAuthorshipService;
        private readonly IUniversityService _universityService;
        private readonly IInstituteService _instituteService;
        private readonly IThesisSubjectTopicService _thesisSubjectTopicService;
        private readonly IKeywordService _keywordService;
        private readonly ISupervisorService _supervisorService;
        private readonly IThesisSupervisionService _thesisSupervisionService;
        private readonly IThesisTypeService _thesisTypeService;

        public ServiceManager(IThesisService thesisService,
            ISubjectTopicService thesisTopicService,
            IAuthorService authorService,
            IThesisAuthorshipService thesisAuthorshipService,
            IUniversityService universityService,
            IInstituteService instituteService,
            IThesisSubjectTopicService thesisSubjectTopicService,
            IKeywordService keywordService,
            ISupervisorService supervisorService,
            IThesisSupervisionService thesisSupervisionService,
            IThesisTypeService thesisTypeService)
        {
            _thesisService = thesisService;
            _subjectTopicService = thesisTopicService;
            _authorService = authorService;
            _thesisAuthorshipService = thesisAuthorshipService;
            _universityService = universityService;
            _instituteService = instituteService;
            _thesisSubjectTopicService = thesisSubjectTopicService;
            _keywordService = keywordService;
            _supervisorService = supervisorService;
            _thesisSupervisionService = thesisSupervisionService;
            _thesisTypeService = thesisTypeService;
        }

        public IThesisService ThesisService => _thesisService;
        public ISubjectTopicService SubjectTopicService => _subjectTopicService;
        public IAuthorService AuthorService => _authorService;

        public IThesisAuthorshipService thesisAuthorshipService => _thesisAuthorshipService;

        public IUniversityService UniversityService => _universityService;

        public IInstituteService InstituteService => _instituteService;

        public IThesisSubjectTopicService ThesisSubjectTopicService => _thesisSubjectTopicService;

        public IKeywordService KeywordService => _keywordService;

        public ISupervisorService SupervisorService => _supervisorService;

        public IThesisSupervisionService ThesisSupervisionService => _thesisSupervisionService;
        public IThesisTypeService ThesisTypeService => _thesisTypeService;
    }
}