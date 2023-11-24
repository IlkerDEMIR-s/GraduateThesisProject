using Entitites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface ISupervisorRepository : IRepositoryBase<Supervisor>
    {
        Supervisor? GetOneSupervisor(int id, bool trackChanges);
        void CreateSupervisor(Supervisor supervisor);
    }
}
