using System.ComponentModel.DataAnnotations;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Yo! Employer Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Yo! Location is required")]
        public string Location { get; set; }

    }
}