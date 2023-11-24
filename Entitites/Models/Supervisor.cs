using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites.Models
{
    public class Supervisor
    {
        [Key] // Add this attribute to specify the primary key
        public int SUPERVISOR_ID { get; set; }
        public string? SUPERVISOR_NAME { get; set; }
    }
}
