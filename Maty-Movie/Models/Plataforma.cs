using System.ComponentModel.DataAnnotations;

namespace Maty_Movie.Models
{
    public class Plataforma
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Url]
        public string Url { get; set; }

        [Url]
        public string LogoUrl { get; set; }

        public List<Pelicula>? PeliculaPlataforma { get; set; }
    }
}
