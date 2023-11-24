using Entitites.Models;

namespace Services.Contracts
{

    public interface IThesisService
    {
       IEnumerable<Thesis> GetAllTheses(bool trackChanges);
       Thesis? GetOneThesis(int id, bool trackChanges);

       void CreateThesis(Thesis thesis);
       
    }
}