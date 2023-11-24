using Entitites.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IThesisAuthorshipService  
    {
        IEnumerable<ThesisAuthorship> GetAllThesisAuthorships(bool trackChanges);
        ThesisAuthorship? GetOneThesisAuthorship(int id, bool trackChanges);
        void CreateThesisAuthorship(ThesisAuthorship thesisAuthorship);
    }
}
