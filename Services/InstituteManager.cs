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
