using Entitites.Models;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Entitites.ViewModels
{
    public class UniversityAndInstituteViewModel
    {
        [Required(ErrorMessage = "Please enter a university name")]
        public University? University { get; set; }

        public Institute? Institute { get; set; }

        public List<string>? EnteredInstitutes { get; set; }

    }

}