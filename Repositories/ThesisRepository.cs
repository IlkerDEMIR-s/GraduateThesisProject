using Entities.RequestParameters;
using Entitites.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.Extensions;


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

        public IQueryable<Thesis> GetAllThesesWithDetails(ThesisRequestParameters t)
        {
            return _context
                   .Thesis
                   .FilterThesesByTypeId(t.TypeId)
                   .FilterThesesBySubjectTopicsByUniversityId(t.UniversityId)
                   .FilterByAuthoId(_context.ThesisSubjectTopics, _context.SubjectTopics, t.SubjectTopicId)
                   .FilterTheserSearchTerm(_context.ThesisAuthorship, _context.Authors, t.authorSearchTerm)
                   .FilterBySupervisorSearchTerm(_context.ThesisSupervision, _context.Supervisor, t.supervisorSearchTerm) 
                   .FilterByTitleSearchTerm(t.titleSearchTerm)
                   .FilterByYear(t.MinYear, t.MaxYear, t.IsValidYearRange)
                   .FilterByKeywordSearchTerm(_context.Keyword, t.keywordSearchTerm);
        }

        public Thesis? GetOneThesis(int id, bool trackChanges)
        {
              return FindByCondition(p => p.THESIS_NO.Equals(id),trackChanges);  
        }

        public IQueryable<Thesis> GetShowcaseTheses(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void UpdateOneThesis(Thesis entity) => Update(entity);

        
       
    }
}