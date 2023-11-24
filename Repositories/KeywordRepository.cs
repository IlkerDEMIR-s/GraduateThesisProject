using Entitites.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class KeywordRepository : RepositoryBase<Keyword>, IKeywordRepository
    {
        public KeywordRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateKeyword(Keyword keyword) => Create(keyword);
        public Keyword? GetOneKeyword(int id, bool trackChanges)
        {
            return FindByCondition(p => p.KEYWORD.Equals(id), trackChanges);
        }
    }
}
