using Entitites.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ThesisTypeRepository : RepositoryBase<ThesisType>, IThesisTypeRepository
    {
        public ThesisTypeRepository(RepositoryContext context) : base(context)
        {
        }

        public ThesisType? GetOneThesisType(int id, bool trackChanges)
        {
            return FindByCondition(t => t.TYPE_ID.Equals(id), trackChanges);
        }

        public void DeleteOneThesisType(ThesisType type) => Remove(type);
        public void CreateOneThesisType(ThesisType type) => Create(type);
    }
}






