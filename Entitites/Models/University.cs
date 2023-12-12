using System.ComponentModel.DataAnnotations;

namespace Entitites.Models
{
    public class University
    {
        [Key] // Add this attribute to specify the primary key
        public int UNIVERSITY_ID { get; set; }
        [Required(ErrorMessage = "University Name is required")] 
        public string UNIVERSITY_NAME { get; set; }
    }
}
