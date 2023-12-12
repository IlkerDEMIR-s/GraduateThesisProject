using Entitites.Models;
using Microsoft.EntityFrameworkCore;
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

        public void CreateOneAuthor(Author author) => Create(author);

        public Author? GetAuthorByAspNetUserId(string id, bool trackChanges)
        {
            return FindByCondition(p => p.ASPNET_USER_ID.Equals(id), trackChanges);
        }

        public Author? GetOneAuthor(int id, bool trackChanges)
        {
            return FindByCondition(p => p.AUTHOR_ID.Equals(id), trackChanges);
        }
    }
}
