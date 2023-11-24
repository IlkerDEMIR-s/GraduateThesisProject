using Entitites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IThesisSupervisionService
    {
        IEnumerable<ThesisSupervision> GetAllThesisSupervisions(bool trackChanges);
        ThesisSupervision? GetOneThesisSupervision(int id, bool trackChanges);
        void CreateThesisSupervision(ThesisSupervision thesisSupervision);
    }
}
