using System.ComponentModel.DataAnnotations;

namespace Entitites.Models
{
    public class University
    {
        [Key] // Add this attribute to specify the primary key
        public int UNIVERSITY_ID { get; set; }
         
        public string UNIVERSITY_NAME { get; set; }
    }
}
