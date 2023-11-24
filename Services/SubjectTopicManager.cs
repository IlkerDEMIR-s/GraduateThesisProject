using Entitites.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{

    public class SubjectTopicManager : ISubjectTopicService
    {
        private  readonly IRepositoryManager _manager;

        public SubjectTopicManager(IRepositoryManager manager)
        {
            _manager = manager;
        }
        public IEnumerable<SubjectTopic> GetAllSubjectTopics(bool trackChanges)
        {
            return _manager.SubjectTopic.FindAll(trackChanges);
        }

        public SubjectTopic? GetOneSubjectTopic(int id, bool trackChanges)
        {
            return _manager.SubjectTopic.GetOneSubjectTopic(id, trackChanges);
        }
    }
}