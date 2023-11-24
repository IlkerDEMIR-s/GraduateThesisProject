using Entitites.Models;

namespace Repositories.Contracts
{
    public interface ISubjectTopicRepository : IRepositoryBase<SubjectTopic>
    {
        SubjectTopic? GetOneSubjectTopic(int id, bool trackChanges);
 
    }
}