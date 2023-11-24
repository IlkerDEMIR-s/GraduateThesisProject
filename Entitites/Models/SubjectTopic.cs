using System.ComponentModel.DataAnnotations;

namespace Entitites.Models;
public class SubjectTopic
{
        [Key] // Add this attribute to specify the primary key
        public int SUBJECT_TOPIC_ID { get; set; }
        public string? SUBJECT_TOPIC_CONTENT { get; set; }

}
