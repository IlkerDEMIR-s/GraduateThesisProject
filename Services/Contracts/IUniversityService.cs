using Entitites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
   public interface IUniversityService
    {
        IEnumerable<University> GetAllUniversities(bool trackChanges);
        University? GetOneUniversity(int id, bool trackChanges);
    }
}
