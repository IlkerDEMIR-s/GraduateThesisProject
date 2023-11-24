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
    public class SupervisorManager : ISupervisorService
    {
        private readonly IRepositoryManager _manager;
        public SupervisorManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateSupervisor(Supervisor supervisor)
        {
            _manager.Supervisor.CreateSupervisor(supervisor);
            _manager.Save();
        }

        public IEnumerable<Supervisor> GetAllSupervisors(bool trackChanges)
        {
            return _manager.Supervisor.FindAll(trackChanges);
        }

        public Supervisor? GetOneSupervisor(int id, bool trackChanges)
        {
            return _manager.Supervisor.GetOneSupervisor(id, trackChanges);
        }
    }
}
