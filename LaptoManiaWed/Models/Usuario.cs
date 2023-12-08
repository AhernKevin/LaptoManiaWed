using LaptoManiaWed.Dtos;
using System.ComponentModel.DataAnnotations;

namespace LaptoManiaWed.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? CorreoElectronico { get; set; }
        [Required]
        public string? Password { get; set; }
        public string? NombreCompleto { get; set; }
        public RolEnum Rol { get; set; }


    }
}
