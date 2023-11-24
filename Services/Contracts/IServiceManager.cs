namespace Services.Contracts
{

   public interface IServiceManager
   {
       IThesisService ThesisService { get; }  
       ISubjectTopicService SubjectTopicService { get; }
       IAuthorService AuthorService { get; }
       IThesisAuthorshipService thesisAuthorshipService { get; }
       IUniversityService UniversityService { get; }
       IInstituteService InstituteService { get; }
       IThesisSubjectTopicService ThesisSubjectTopicService { get; }
       IKeywordService KeywordService { get; }
       ISupervisorService SupervisorService { get; }
       IThesisSupervisionService ThesisSupervisionService { get; }
       IThesisTypeService ThesisTypeService { get; }
   }


}