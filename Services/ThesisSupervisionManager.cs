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
    public class ThesisSupervisionManager : IThesisSupervisionService
    {
        private readonly IRepositoryManager _manager;

        public ThesisSupervisionManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateThesisSupervision(ThesisSupervision thesisSupervision)
        {
            _manager.ThesisSupervision.CreateThesisSupervision(thesisSupervision);
            _manager.Save();
        }

        public IEnumerable<ThesisSupervision> GetAllThesisSupervisions(bool trackChanges)
        {
            return _manager.ThesisSupervision.FindAll(trackChanges);
        }

        public ThesisSupervision? GetOneThesisSupervision(int id, bool trackChanges)
        {
            return _manager.ThesisSupervision.GetOneThesisSupervision(id, trackChanges);
        }
    }
}
