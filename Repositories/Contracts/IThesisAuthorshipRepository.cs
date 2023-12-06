using Entitites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IThesisAuthorshipRepository : IRepositoryBase<ThesisAuthorship>
    {       
        ThesisAuthorship? GetOneThesisAuthorship(int id, bool trackChanges);
        void CreateThesisAuthorship(ThesisAuthorship thesisAuthorship);
        void DeleteOneThesisAuthorship(ThesisAuthorship thesisAuthorship);
    }
}
