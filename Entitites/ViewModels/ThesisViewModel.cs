using Entitites.Models;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Entitites.ViewModels
{
    public class ThesisViewModel
    {
        public Thesis Thesis { get; set; }
        public Author? Author { get; set; }
        public University? University { get; set; }
        public Institute? Institute { get; set; }
        public SubjectTopic? SubjectTopic { get; set; }
        public List<SubjectTopic>? SubjectTopics { get; set; }
        public Supervisor? Supervisor { get; set; }
        public Supervisor? CoSupervisor { get; set; }
        private Keyword? Keyword { get; set; }
        public List<Keyword>? Keywords { get; set; }
        public ThesisAuthorship? ThesisAuthorship { get; set; }
        public List<string>? EnteredKeywords { get; set; }
        public ThesisType? ThesisType { get; set; }

        [Required (ErrorMessage = "Please enter a Supervisor Name.")]
            public string SupervisorName => Supervisor?.SUPERVISOR_NAME ?? "";

        [Required (ErrorMessage = "Please select a valid subject.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a valid subject.")]
            public int SubjectTopicId => SubjectTopic?.SUBJECT_TOPIC_ID ?? 0;

        private int currentYear = DateTime.Now.Year;

        [Required(ErrorMessage = "Please enter a valid thesis year.")]
        public int ThesisYear => Thesis?.YEAR ?? 0;

        // Validation method for ThesisYear
        public bool IsThesisYearValid()
        {
            return ThesisYear >= 1800 && ThesisYear <= currentYear;
        }
    
    }
}






