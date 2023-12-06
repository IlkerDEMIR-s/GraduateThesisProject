using Entities.RequestParameters;
using Entitites.Models;

namespace Services.Contracts
{

    public interface IThesisService
    {
       IEnumerable<Thesis> GetAllTheses(bool trackChanges);

        IQueryable<Thesis> GetAllThesesWithDetails(ThesisRequestParameters p);
        Thesis? GetOneThesis(int id, bool trackChanges);

       void CreateThesis(Thesis thesis);

       void UpdateOneThesis(Thesis thesis);

       void DeleteOneThesis(int id);
       
    }
}