using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Maty_Movie.Models
{
    public class Usuario : IdentityUser
    {
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        public string ImagenUrlPerfil { get; set; }

       public List <Favoritos>? PeliculasFavoritas { get; set; }



    }
}
