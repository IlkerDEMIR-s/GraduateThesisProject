using Entitites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IThesisSubjectTopicRepository : IRepositoryBase<ThesisSubjectTopic>
    {
        ThesisSubjectTopic? GetOneThesisSubjectTopic(int id, bool trackChanges);
        void CreateThesisSubjectTopic(ThesisSubjectTopic thesisSubjectTopic);
    }
}   
