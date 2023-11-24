using Entitites.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;


namespace Repositories
{
    public sealed class ThesisRepository : RepositoryBase<Thesis>, IThesisRepository
    {
        public ThesisRepository(RepositoryContext context) : base(context)
        {

        }

        public void CreateOneThesis(Thesis thesis) => Create(thesis);

        public void DeleteOneThesis(Thesis thesis) => Remove(thesis);

        public IQueryable<Thesis> GetAllTheses(bool trackChanges) => FindAll(trackChanges);

        /*public IQueryable<Thesis> GetAllThesesWithDetails(ProductRequestParameters p)
        {
            return _context
                .Products
                .FilteredByCategoryId(p.CategoryId)
                .FilteredBySearchTerm(p.SearchTerm)
        }*/

        // Interface
        public Thesis? GetOneThesis(int id, bool trackChanges)
        {
              return FindByCondition(p => p.THESIS_NO.Equals(id),trackChanges);  
        }

        public IQueryable<Thesis> GetShowcaseTheses(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        /*public IQueryable<Thesis> GetShowcaseTheses(bool trackChanges)
        {
            return FindAll(trackChanges)
                .Where(p => p.ShowCase.Equals(true));
        }*/

        public void UpdateOneThesis(Thesis entity) => Update(entity);
       
    }
}