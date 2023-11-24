using System.ComponentModel.DataAnnotations;

namespace Entitites.Models;
public class Thesis
{
        [Key] // Add this attribute to specify the primary key
        public decimal THESIS_NO { get; set; }
        public string? TITLE { get; set; }
        public string? ABSTRACT { get; set; }
        public short? YEAR { get; set; }
        public int TYPE_ID { get; set; }
        public int UNIVERSITY_ID { get; set; }
        public int INSTITUTE_ID { get; set; }
        public int AUTHOR_ID { get; set; }
        public int NUM_PAGES { get; set; }
        public string? LANGUAGE { get; set; }
        public DateTime? SUBMISSION_DATE { get; set; } 

}
