namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IThesisRepository Thesis {get; }
        ISubjectTopicRepository SubjectTopic {get; }
        IAuthorRepository Author { get; }
        IThesisAuthorshipRepository ThesisAuthorship { get; }
        IUniversityRepository University { get; }
        IInstituteRepository Institute { get; }
        IThesisSubjectTopicRepository ThesisSubjectTopic { get; }
        IKeywordRepository Keyword { get; }
        ISupervisorRepository Supervisor { get; }
        IThesisSupervisionRepository ThesisSupervision { get; }
        IThesisTypeRepository ThesisType { get; }

        void Save();
    }
}