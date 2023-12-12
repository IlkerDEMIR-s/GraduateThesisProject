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
        public void CreateThesisType(ThesisType type)
        {
            _manager.ThesisType.Create(type);
            _manager.Save();
        }

        public void DeleteOneThesisType(int id)
        {
            var type = GetOneThesisType(id, true);
            if (type is not null)
            {
                _manager.ThesisType.DeleteOneThesisType(type);
                _manager.Save();
            }
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
