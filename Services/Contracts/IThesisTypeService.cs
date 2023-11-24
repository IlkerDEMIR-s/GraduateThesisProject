using Entitites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IThesisTypeService
    {
        IEnumerable<ThesisType> GetAllThesisTypes(bool trackChanges);
        ThesisType? GetOneThesisType(int id, bool trackChanges);
    }
}