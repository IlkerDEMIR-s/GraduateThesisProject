using Entitites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IThesisTypeRepository : IRepositoryBase<ThesisType> 
    {
        ThesisType? GetOneThesisType(int id, bool trackChanges);

    }
}











