using Entitites.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ThesisManager : IThesisService
    {
        private readonly IRepositoryManager _manager;

        public ThesisManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateThesis(Thesis thesis)
        {
            _manager.Thesis.Create(thesis);
            _manager.Save();
        }   

        public IEnumerable<Thesis> GetAllTheses(bool trackChanges)
        {
            return _manager.Thesis.GetAllTheses(trackChanges);
        }

        public Thesis? GetOneThesis(int id, bool trackChanges)
        {
            var thesis = _manager.Thesis.GetOneThesis(id, trackChanges);
            if (thesis == null)
            {
                throw new Exception("Thesis not found");
            }
            return thesis;
            
        }
    }


}