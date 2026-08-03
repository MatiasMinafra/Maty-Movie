using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Maty_Movie.Models
{
    public class Pelicula
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Titulo { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaLanzamiento { get; set; }

        [Required]
        [Range(1, 500)]
        public int MinutosDuracion { get; set; }

        [Required]
        public string Sinopsis { get; set; }

        public string PosterUrlPortada { get; set; }

        public int GeneroId { get; set; }
        public Genero? Genero { get; set; }

        public int PlataformaId { get; set; }
        public Plataforma? Plataforma { get; set; }

        public int PromedioRating { get; set; }

        public List<Review>? ListaReviews { get; set; }

        public List<Favoritos>? UsuariosFavoritos { get; set; }



    }
}
