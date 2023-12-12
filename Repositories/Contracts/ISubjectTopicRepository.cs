using Entitites.Models;

namespace Repositories.Contracts
{
    public interface ISubjectTopicRepository : IRepositoryBase<SubjectTopic>
    {
        void CreateSubjectTopic(SubjectTopic newSubjectTopic);
        void DeleteOneSubjectTopic(SubjectTopic subjectTopic);
        SubjectTopic? GetOneSubjectTopic(int id, bool trackChanges);
 
    }
}