using System.ComponentModel.DataAnnotations;

namespace EmployeesBD.ViewModels
{
    //on a ajouté de new fonctionnalité (dossier images souss wwwroot) pour faire file upload IFormFile
    public class CreateViewModel
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Taille Max 50 cc")]
        public string Name { get; set; }
        public string Department { get; set; }
        [Range(300, 5000, ErrorMessage = "Doit être entre 300 et 5000")]
        public int Salary { get; set; }
        public IFormFile Photo { get; set; }
    }
}
