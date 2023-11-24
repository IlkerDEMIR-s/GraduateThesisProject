using Entitites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IKeywordService
    {
        IEnumerable<Keyword> GetAllKeywords(bool trackChanges);
        Keyword? GetOneKeyword(int id, bool trackChanges);
        void CreateKeyword(Keyword keyword);
    }
}
