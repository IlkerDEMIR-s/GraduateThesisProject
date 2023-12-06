using Entitites.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ThesisAuthorshipRepository : RepositoryBase<ThesisAuthorship>, IThesisAuthorshipRepository
    {
        public ThesisAuthorshipRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateThesisAuthorship(ThesisAuthorship thesisAuthorship)=> Create(thesisAuthorship);

        public void DeleteOneThesisAuthorship(ThesisAuthorship thesisAuthorship) => Remove(thesisAuthorship);

        public ThesisAuthorship? GetOneThesisAuthorship(int id, bool trackChanges)
        {
            return FindByCondition(p => p.THESIS_NO.Equals(id), trackChanges);
        }
    }

}
