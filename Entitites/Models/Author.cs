using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites.Models
{
    public class Author
    {
        [Key] // Add this attribute to specify the primary key
        public int AUTHOR_ID { get; set; }
        public string? AUTHOR_NAME { get; set; }
    }
}
