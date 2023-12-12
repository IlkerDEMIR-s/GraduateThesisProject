using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites.Models
{
    public class ThesisType
    {
        [Key] // Add this attribute to specify the primary key
        public int TYPE_ID { get; set; }
        [Required (ErrorMessage = "Please enter a type name")]
        public string TYPE_NAME { get; set; }
    }
}
