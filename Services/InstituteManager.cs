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
    public class InstituteManager : IInstituteService
    {
        private readonly IRepositoryManager _manager;

        public InstituteManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateInstitute(Institute institute)
        {
            _manager.Institute.Create(institute);
            _manager.Save();
        }

        public void  DeleteOneInstitute(int id)
        {
            var institute = GetOneInstitute(id, true);
            if (institute is not null)
            {
                _manager.Institute.DeleteOneInstitute(institute);
                _manager.Save();
            }
        }

        public void DeleteInstitutesByUniversityId(int id)
        {
            var institutes = GetAllInstitutes(true).Where(i => (int)i.UNIVERSITY_ID == id);
            foreach (var institute in institutes)
            {
                _manager.Institute.DeleteInstitutes(institute);
            }
            _manager.Save();
        }

        public IEnumerable<Institute> GetAllInstitutes(bool trackChanges)
        {
            return _manager.Institute.FindAll(trackChanges);
        }

        public Institute? GetOneInstitute(int id, bool trackChanges)
        {
            return _manager.Institute.GetOneInstitute(id, trackChanges);
        }
    }
}
