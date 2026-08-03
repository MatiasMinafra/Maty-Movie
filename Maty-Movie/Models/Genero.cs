using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace Maty_Movie.Models
{
    public class Genero
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        public List<Pelicula>? PeliculasGenero { get; set; }
    }
}

