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

        public void CreateSubjectTopic(SubjectTopic newSubjectTopic)
        {
            _manager.SubjectTopic.Create(newSubjectTopic);
            _manager.Save();
        }

        public void DeleteSubjectTopic(int id)
        {
            var subjectTopic = GetOneSubjectTopic(id, true);
            if (subjectTopic is not null)
            {
              _manager.SubjectTopic.DeleteOneSubjectTopic(subjectTopic);
              _manager.Save();
            }
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