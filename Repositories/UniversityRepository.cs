using Entitites.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UniversityRepository : RepositoryBase<University>, IUniversityRepository
    {
        public UniversityRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneUniversity(University university) => Create(university);

        public void DeleteOneUniversity(University university) => Remove(university);

        public University? GetOneUniversity(int id, bool trackChanges)
        {
            return FindByCondition(p => p.UNIVERSITY_ID.Equals(id), trackChanges);
        }
    }
}
