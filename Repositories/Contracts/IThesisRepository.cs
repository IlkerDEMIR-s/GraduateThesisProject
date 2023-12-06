using Entitites.Models;
using Entities.RequestParameters;

namespace Repositories.Contracts
{
    public interface IThesisRepository : IRepositoryBase<Thesis>
    {
        IQueryable<Thesis> GetAllTheses(bool trackChanges);
        IQueryable<Thesis> GetAllThesesWithDetails(ThesisRequestParameters p);
        IQueryable<Thesis> GetShowcaseTheses(bool trackChanges);
        Thesis? GetOneThesis(int id, bool trackChanges);
        void CreateOneThesis(Thesis thesis);        
        void UpdateOneThesis(Thesis entity);
        void DeleteOneThesis(Thesis thesis);
    }
}