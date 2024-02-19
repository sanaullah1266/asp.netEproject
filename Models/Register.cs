using System.ComponentModel.DataAnnotations;

namespace E_project_book_mangement_system.Models
{
    public class Register
    {
        [Key]
        public int userid { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }

    }
}
