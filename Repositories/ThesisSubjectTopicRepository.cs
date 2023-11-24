using Entitites.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ThesisSubjectTopicRepository : RepositoryBase<ThesisSubjectTopic>, IThesisSubjectTopicRepository
    {
        public ThesisSubjectTopicRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateThesisSubjectTopic(ThesisSubjectTopic thesisSubjectTopic) => Create(thesisSubjectTopic);

        public ThesisSubjectTopic? GetOneThesisSubjectTopic(int id, bool trackChanges)
        {
            return FindByCondition(p => p.THESIS_NO.Equals(id), trackChanges);
        }
    }
}
