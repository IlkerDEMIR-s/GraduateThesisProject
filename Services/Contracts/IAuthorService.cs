using Entitites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IAuthorService
    {
        void CreateAuthor(Author author);
        IEnumerable<Author> GetAllAuthors(bool trackChanges);
        Author? GetOneAuthor(int id, bool trackChanges);
        Author? GetAuthorByAspNetUserId(string id, bool trackChanges);
    }
}
