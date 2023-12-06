using Entitites.Models;

namespace Repositories.Extensions
{
    public static class ThesisRepositoryExtension
    {
        public static IQueryable<Thesis> FilterThesesByTypeId(this IQueryable<Thesis> theses,
         int? typeId)
        {
           if (typeId is null)
           {
               return theses;
           }
           else
           {
                return theses.Where(p => p.TYPE_ID.Equals(typeId));
           }
        }

        public static IQueryable<Thesis> FilterThesesByUniversityId(this IQueryable<Thesis> theses,
         int? universityId)
        {
           if (universityId is null)
           {
               return theses;
           }
           else
           {
                return theses.Where(p => p.UNIVERSITY_ID.Equals(universityId));
           }
        }


        public static IQueryable<Thesis> FilterThesesBySubjectTopicId(this IQueryable<Thesis> theses,
        IQueryable<ThesisSubjectTopic> thesisSubjectTopic, IQueryable<SubjectTopic> subjectTopic,
         int? subjectTopicId)
        {
           if (subjectTopicId is null)
           {
               return theses;
           }
           else
           {
                return theses
                       .Join(thesisSubjectTopic, thesis => thesis.THESIS_NO, thesisTopic => thesisTopic.THESIS_NO,
                             (thesis, thesisTopic) => new { Thesis = thesis, ThesisTopic = thesisTopic })
                       .Join(subjectTopic, joint => joint.ThesisTopic.SUBJECT_TOPIC_ID, topic => topic.SUBJECT_TOPIC_ID,
                            (joint, topic) => new { Joint = joint, Topic = topic })
                       .Where(joined => joined.Topic.SUBJECT_TOPIC_ID.Equals(subjectTopicId))
                       .Select(joined => joined.Joint.Thesis);
                
           }
        }

        public static IQueryable<Thesis> FilterByAuthorSearchTerm(this IQueryable<Thesis> theses,
         IQueryable<ThesisAuthorship> thesisAuthorship, IQueryable<Author> Author,
         string? authorSearchTerm)
        {
           if (string.IsNullOrWhiteSpace(authorSearchTerm))
           {
               return theses;
           }
           else
           {
                return theses
                    .Join(thesisAuthorship, thesis => thesis.THESIS_NO, authorship => authorship.THESIS_NO,
                        (thesis, authorship) => new { Thesis = thesis, Authorship = authorship })
                    .Join(Author, joint => joint.Authorship.AUTHOR_ID, author => author.AUTHOR_ID,
                        (joint, author) => new { Joint = joint, Author = author })
                    .Where(joined => joined.Author.AUTHOR_NAME.ToLower().Contains(authorSearchTerm.Trim().ToLower()))
                    .Select(joined => joined.Joint.Thesis);
            }
        }

        public static IQueryable<Thesis> FilterBySupervisorSearchTerm(this IQueryable<Thesis> theses,
         IQueryable<ThesisSupervision> thesisSupervision, IQueryable<Supervisor> supervisor,
         string? supervisorSearchTerm)
        {
           if (string.IsNullOrWhiteSpace(supervisorSearchTerm))
           {
               return theses;
           }
           else
           {
                return theses
                    .Join(thesisSupervision, thesis => thesis.THESIS_NO, supervision => supervision.THESIS_NO,
                        (thesis, supervision) => new { Thesis = thesis, Supervision = supervision })
                    .Join(supervisor, joint => joint.Supervision.SUPERVISOR_ID, supervisor => supervisor.SUPERVISOR_ID,
                        (joint, supervisor) => new { Joint = joint, Supervisor = supervisor })
                    .Where(joined => joined.Supervisor.SUPERVISOR_NAME.ToLower().Contains(supervisorSearchTerm.Trim().ToLower()))
                    .Select(joined => joined.Joint.Thesis);
            }
        }

        public static IQueryable<Thesis> FilterByKeywordSearchTerm(this IQueryable<Thesis> theses,
         IQueryable<Keyword> keyword,string? keywordSearchTerm)
        {
           if (string.IsNullOrWhiteSpace(keywordSearchTerm))
           {
               return theses;
           }
           else
           {
                return theses
                       .Join(keyword, thesis => thesis.THESIS_NO, keyword => keyword.THESIS_NO,
                                              (thesis, keyword) => new { Thesis = thesis, Keyword = keyword })
                    .Where(joined => joined.Keyword.KEYWORD.ToLower().Contains(keywordSearchTerm.Trim().ToLower()))
                    .Select(joined => joined.Thesis);   
            }
        }


        public static IQueryable<Thesis> FilterByTitleSearchTerm(this IQueryable<Thesis> theses,
         String? titleSearchTerm)
        {
            if (string.IsNullOrWhiteSpace(titleSearchTerm))
            {
                return theses;
            }
            else
            {
                return theses.Where(t => t.TITLE.ToLower()
                .Contains(titleSearchTerm.Trim().ToLower()));
            }           
        }
        

        public static IQueryable<Thesis> FilterByYear(this IQueryable<Thesis> theses,
         int? minYear, int? maxYear, bool isValidYearRange)
        {
            if(isValidYearRange)
            {
                return theses.Where(t => t.YEAR >= minYear && t.YEAR <= maxYear);
            }
            else
            {
                return theses;
            }
        
        }
    }
}