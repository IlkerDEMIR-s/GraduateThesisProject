using Entitites.Models;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Entitites.ViewModels
{
    public class UpdateViewModel
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
        public ThesisSupervision? ThesisSupervision { get; set; }

 
    
    }
}






