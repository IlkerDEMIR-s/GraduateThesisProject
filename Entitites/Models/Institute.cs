using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites.Models
{
    public class Institute
    {
        [Key] // Add this attribute to specify the primary key
        public int INSTITUTE_ID { get; set; }
        public string INSTITUTE_NAME { get; set; }
        public int UNIVERSITY_ID { get; set; }
    }
}
