using Entitites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface ISupervisorService
    {
        IEnumerable<Supervisor> GetAllSupervisors(bool trackChanges);
        Supervisor? GetOneSupervisor(int id, bool trackChanges);
        void CreateSupervisor(Supervisor supervisor);
    }
}
