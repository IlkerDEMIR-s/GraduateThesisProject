using Entitites.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class InstitudeRepository : RepositoryBase<Institute>, IInstituteRepository
    {
        public InstitudeRepository(RepositoryContext context) : base(context)
        {
        }


        public Institute? GetOneInstitute(int id, bool trackChanges)
        {
            return FindByCondition(p => p.INSTITUTE_ID.Equals(id), trackChanges);
        }

        public void DeleteOneInstitute(Institute institute) => Remove(institute);
        public void CreateOneInstitute(Institute institute) => Create(institute);
        public void DeleteInstitutes(Institute institute) => Remove(institute);
      
    }
}
