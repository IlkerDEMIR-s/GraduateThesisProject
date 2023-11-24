using Entitites.Models;

namespace Repositories.Contracts
{
    public interface IThesisRepository : IRepositoryBase<Thesis>
    {
        IQueryable<Thesis> GetAllTheses(bool trackChanges);
        //IQueryable<Thesis> GetAllThesessWithDetails(ProductRequestParameters p);
        IQueryable<Thesis> GetShowcaseTheses(bool trackChanges);
        Thesis? GetOneThesis(int id, bool trackChanges);
        void CreateOneThesis(Thesis thesis);
        void DeleteOneThesis(Thesis thesis);
        void UpdateOneThesis(Thesis entity);
    }
}