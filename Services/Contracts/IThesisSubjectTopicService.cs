using Entitites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IThesisSubjectTopicService
    {
        IEnumerable<ThesisSubjectTopic> GetAllThesisSubjectTopics(bool trackChanges);
        ThesisSubjectTopic? GetOneThesisSubjectTopic(int id, bool trackChanges);
        void CreateThesisSubjectTopic(ThesisSubjectTopic thesisSubjectTopic);
    }
}
