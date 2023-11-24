using Entitites.Models;
using Repositories.Contracts;
using Services.Contracts;


namespace Services
{
    public class ThesisTypeManager : IThesisTypeService
    {
        private readonly IRepositoryManager _manager;

        public ThesisTypeManager(IRepositoryManager manager)
        {
            _manager = manager;
        }
        public IEnumerable<ThesisType> GetAllThesisTypes(bool trackChanges)
        {
            return _manager.ThesisType.FindAll(trackChanges);
        }

        public ThesisType? GetOneThesisType(int id, bool trackChanges)
        {
            return _manager.ThesisType.GetOneThesisType(id, trackChanges);
        }
    }
}
