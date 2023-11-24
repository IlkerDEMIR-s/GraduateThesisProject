using Entitites.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class SupervisorRepository : RepositoryBase<Supervisor>, ISupervisorRepository
    {
        public SupervisorRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateSupervisor(Supervisor supervisor) => Create(supervisor);

        public Supervisor? GetOneSupervisor(int id, bool trackChanges)
        {
            return FindByCondition(p => p.SUPERVISOR_ID.Equals(id), trackChanges);
        }
    }
}
