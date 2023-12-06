using Entitites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IThesisSupervisionRepository : IRepositoryBase<ThesisSupervision>
    {
        ThesisSupervision? GetOneThesisSupervision(int id, bool trackChanges);
        void CreateThesisSupervision(ThesisSupervision thesisSupervision);
        void DeleteOneThesisSupervision(ThesisSupervision thesisSupervision);
    }
}
