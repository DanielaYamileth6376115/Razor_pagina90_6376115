using System.ComponentModel.DataAnnotations;

namespace Razor_Pag90.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string Email { get; set; }
    }
}