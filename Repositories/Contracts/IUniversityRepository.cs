using Entitites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IUniversityRepository : IRepositoryBase<University>
    {
        University? GetOneUniversity(int id, bool trackChanges);

    }
}
