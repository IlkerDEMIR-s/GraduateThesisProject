using Entitites.Models;

namespace Services.Contracts
{
    public interface ISubjectTopicService
    {
        void CreateSubjectTopic(SubjectTopic newSubjectTopic);
        void DeleteSubjectTopic(int id);
        IEnumerable<SubjectTopic> GetAllSubjectTopics(bool trackChanges);
        SubjectTopic? GetOneSubjectTopic(int id, bool trackChanges);
    }
}
