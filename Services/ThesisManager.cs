using Entities.RequestParameters;
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

        public void UpdateOneThesis(Thesis thesis)
        {
            var entity = _manager.Thesis.GetOneThesis((int)thesis.THESIS_NO, true);
            entity.YEAR = thesis.YEAR;
            entity.TITLE = thesis.TITLE;
            entity.ABSTRACT = thesis.ABSTRACT;
            entity.UNIVERSITY_ID = thesis.UNIVERSITY_ID;
            entity.INSTITUTE_ID = thesis.INSTITUTE_ID;
            entity.LANGUAGE = thesis.LANGUAGE;
            entity.TYPE_ID = thesis.TYPE_ID;
            entity.NUM_PAGES = thesis.NUM_PAGES;
            entity.SUBMISSION_DATE = thesis.SUBMISSION_DATE;

            _manager.Save();
        }

        public void DeleteOneThesis(int id)
        {
            var thesis = GetOneThesis(id, true);
            if (thesis is not null)
            {
              _manager.Thesis.DeleteOneThesis(thesis);       
              _manager.Save();
            }
        }

        public IQueryable<Thesis> GetAllThesesWithDetails(ThesisRequestParameters p)
        {
            return _manager.Thesis.GetAllThesesWithDetails(p);
        }
    }


}