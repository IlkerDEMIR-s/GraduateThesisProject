using Entitites.Models;

namespace Services.Contracts
{
    public interface ISubjectTopicService
    {
        IEnumerable<SubjectTopic> GetAllSubjectTopics(bool trackChanges);
        SubjectTopic? GetOneSubjectTopic(int id, bool trackChanges);
    }
}
