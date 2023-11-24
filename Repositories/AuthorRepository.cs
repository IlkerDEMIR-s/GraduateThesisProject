using Entitites.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
    {
        public AuthorRepository(RepositoryContext context) : base(context)
        {
        }

        public Author? GetOneAuthor(int id, bool trackChanges)
        {
            return FindByCondition(p => p.AUTHOR_ID.Equals(id), trackChanges);
        }
    }
}
