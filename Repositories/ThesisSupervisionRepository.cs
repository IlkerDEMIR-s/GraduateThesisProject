using Entitites.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ThesisSupervisionRepository : RepositoryBase<ThesisSupervision>, IThesisSupervisionRepository
    {
        public ThesisSupervisionRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateThesisSupervision(ThesisSupervision thesisSupervision)=> Create(thesisSupervision);

        public ThesisSupervision? GetOneThesisSupervision(int id, bool trackChanges)
        {
            return FindByCondition(p => p.THESIS_NO.Equals(id), trackChanges);
        }
    }
}
