using Entitites.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class KeywordManager : IKeywordService
    {
        private readonly IRepositoryManager _manager;
        public KeywordManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateKeyword(Keyword keyword)
        {
            _manager.Keyword.CreateKeyword(keyword);
            _manager.Save();
        }

        public void DeleteKeywordsByThesisId(int id)
        {
            var keywords = GetAllKeywords(true).Where(k => (int)k.THESIS_NO == id);
            foreach (var keyword in keywords)
            {
                _manager.Keyword.DeleteKeywords(keyword);
            }
                _manager.Save();

        }

        public void DeleteOneKeyword(int id)
        {
            var keyword = GetOneKeyword(id, true);
            if (keyword is not null)
            {
                _manager.Keyword.DeleteOneKeyword(keyword);
                _manager.Save();
            }
        }

        public IEnumerable<Keyword> GetAllKeywords(bool trackChanges)
        {
            return _manager.Keyword.FindAll(trackChanges);
        }

        public Keyword? GetOneKeyword(int id, bool trackChanges)
        {
            return _manager.Keyword.GetOneKeyword(id, trackChanges);
        }
    }
}
