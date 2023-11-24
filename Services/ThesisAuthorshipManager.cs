using Entitites.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ThesisAuthorshipManager : IThesisAuthorshipService
    {
        private readonly IRepositoryManager _manager;

        public ThesisAuthorshipManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateThesisAuthorship(ThesisAuthorship thesisAuthorship)
        {
            _manager.ThesisAuthorship.Create(thesisAuthorship);
            _manager.Save();
        }

        public IEnumerable<ThesisAuthorship> GetAllThesisAuthorships(bool trackChanges)
        {
            return _manager.ThesisAuthorship.FindAll(trackChanges);
        }

        public ThesisAuthorship? GetOneThesisAuthorship(int id, bool trackChanges)
        {
            return _manager.ThesisAuthorship.GetOneThesisAuthorship(id, trackChanges);
        }
    }
}
