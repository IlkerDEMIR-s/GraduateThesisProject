using Entitites.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;


namespace Repositories
{
    public sealed class SubjectTopicRepository : RepositoryBase<SubjectTopic>, ISubjectTopicRepository
    {
        public SubjectTopicRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateSubjectTopic(SubjectTopic newSubjectTopic) => Create(newSubjectTopic);
        public void DeleteOneSubjectTopic(SubjectTopic subjectTopic) => Remove(subjectTopic);

        public SubjectTopic? GetOneSubjectTopic(int id, bool trackChanges)
        {
            return FindByCondition(p => p.SUBJECT_TOPIC_ID.Equals(id), trackChanges);
        }
    }
}