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
        IEnumerable<Author> GetAllAuthors(bool trackChanges);
        Author? GetOneAuthor(int id, bool trackChanges);
    }
}
