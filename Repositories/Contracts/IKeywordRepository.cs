using Entitites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IKeywordRepository : IRepositoryBase<Keyword>
    {
        Keyword? GetOneKeyword(int id, bool trackChanges);
        void CreateKeyword(Keyword keyword);
        void DeleteOneKeyword(Keyword keyword);
        void DeleteKeywords(Keyword keyword);
    }
}
