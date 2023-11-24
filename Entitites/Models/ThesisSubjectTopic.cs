using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites.Models
{
    public class ThesisSubjectTopic
    {
        [Key] // Add this attribute to specify the primary key
        public decimal THESIS_NO { get; set; }
        [Key] // Add this attribute to specify the primary key
        public int SUBJECT_TOPIC_ID { get; set; }
    }
}
