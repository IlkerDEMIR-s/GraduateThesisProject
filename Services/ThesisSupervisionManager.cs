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

        public void DeleteOneThesisSupervision(int id)
        {
            var thesisSupervision = GetOneThesisSupervision(id, true);
            if (thesisSupervision is not null)
            {
              _manager.ThesisSupervision.DeleteOneThesisSupervision(thesisSupervision);       
              _manager.Save();
            }
        }

        public IEnumerable<ThesisSupervision> GetAllThesisSupervisions(bool trackChanges)
        {
            return _manager.ThesisSupervision.FindAll(trackChanges);
        }

        public ThesisSupervision? GetOneThesisSupervision(int id, bool trackChanges)
        {
            return _manager.ThesisSupervision.GetOneThesisSupervision(id, trackChanges);
        }

        public void UpdateOneThesisSupervision(ThesisSupervision thesisSupervision)
        {
            var entity = _manager.ThesisSupervision.GetOneThesisSupervision((int)thesisSupervision.THESIS_NO, true);
            
            entity.SUPERVISOR_ID = thesisSupervision.SUPERVISOR_ID;
            entity.CO_SUPERVISOR_ID = thesisSupervision?.CO_SUPERVISOR_ID;  
        
            _manager.Save();
        }        



    }
}
