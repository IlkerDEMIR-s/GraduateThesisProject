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
    public class UniversityManager : IUniversityService
    {
        private readonly IRepositoryManager _manager;

        public UniversityManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateUniversity(University newUniversity)
        {
            _manager.University.Create(newUniversity);  
            _manager.Save();
        }

        public void DeleteUniversity(int id)
        {
            var university = GetOneUniversity(id, true);
            if (university is not null)
            {
                _manager.University.DeleteOneUniversity(university);
                _manager.Save();
            }
        }

        public IEnumerable<University> GetAllUniversities(bool trackChanges)
        {
            return _manager.University.FindAll(trackChanges);
        }

        public University? GetOneUniversity(int id, bool trackChanges)
        {
            return _manager.University.GetOneUniversity(id, trackChanges);
        }
    }
}
