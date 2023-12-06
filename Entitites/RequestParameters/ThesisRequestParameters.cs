namespace Entities.RequestParameters
{
    public class ThesisRequestParameters : RequestParameters
    {
        public int? SubjectTopicId { get; set; }
        public int? TypeId { get; set; }      
        public int? UniversityId { get; set; }  
        public int? MaxYear { get; set; } = short.MaxValue;  // because the year is a short (int16/smallint)
        public int? MinYear { get; set; } = 0;
        public bool IsValidYearRange => MaxYear > MinYear;
        public string? authorSearchTerm { get; set; }
        public string? titleSearchTerm { get; set; }
        public string? supervisorSearchTerm { get; set; }
        public string? keywordSearchTerm { get; set; }

    }
}