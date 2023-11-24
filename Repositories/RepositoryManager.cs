using Repositories.Contracts;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IThesisRepository _thesisRepository;
        private readonly ISubjectTopicRepository _subjectTopicRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly IThesisAuthorshipRepository _theAuthRepository;
        private readonly IUniversityRepository _universityRepository;
        private readonly IInstituteRepository _instituteRepository;
        private readonly IThesisSubjectTopicRepository _thesisSubjectTopicRepository;
        private readonly IKeywordRepository _keywordRepository;
        private readonly ISupervisorRepository _supervisorRepository;
        private readonly IThesisSupervisionRepository _thesisSupervisionRepository;
        private readonly IThesisTypeRepository _thesisTypeRepository;


        public RepositoryManager(RepositoryContext repositoryContext,
            IThesisRepository thesisRepository,
            ISubjectTopicRepository subjectTopicRepository,
            IAuthorRepository authorRepository,
            IThesisAuthorshipRepository theAuthRepository,
            IUniversityRepository universityRepository,
            IInstituteRepository instituteRepository,
            IThesisSubjectTopicRepository thesisSubjectTopicRepository,
            IKeywordRepository keywordRepository,
            ISupervisorRepository supervisorRepository,
            IThesisSupervisionRepository thesisSupervisionRepository,
            IThesisTypeRepository thesisTypeRepository)
        {
            _context = repositoryContext;
            _thesisRepository = thesisRepository;
            _subjectTopicRepository = subjectTopicRepository;
            _authorRepository = authorRepository;
            _theAuthRepository = theAuthRepository;
            _universityRepository = universityRepository;
            _instituteRepository = instituteRepository;
            _thesisSubjectTopicRepository = thesisSubjectTopicRepository;
            _keywordRepository = keywordRepository;
            _supervisorRepository = supervisorRepository;
            _thesisSupervisionRepository = thesisSupervisionRepository;
            _thesisTypeRepository = thesisTypeRepository;
        }

        public IThesisRepository Thesis => _thesisRepository;

        public ISubjectTopicRepository SubjectTopic => _subjectTopicRepository;

        public IAuthorRepository Author => _authorRepository;

        public IThesisAuthorshipRepository ThesisAuthorship => _theAuthRepository;

        public IUniversityRepository University => _universityRepository;

        public IInstituteRepository Institute => _instituteRepository;

        public IThesisSubjectTopicRepository ThesisSubjectTopic => _thesisSubjectTopicRepository;

        public IKeywordRepository Keyword => _keywordRepository;

        public ISupervisorRepository Supervisor => _supervisorRepository;

        public IThesisSupervisionRepository ThesisSupervision => _thesisSupervisionRepository;
        public IThesisTypeRepository ThesisType => _thesisTypeRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}