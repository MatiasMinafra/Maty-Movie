using System.ComponentModel.DataAnnotations;

namespace Maty_Movie.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int PeliculaId { get; set; }
        public Pelicula? pelicula { get; set; }
        public string UsuarioId { get; set; }

        public Usuario? usuario { get; set; }
        [Range(1,5)]
        public int Rating { get; set; }
        [Required]
        [StringLength(500)]
        public string Comentario { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaReview { get; set; }
        [Timestamp]
        public byte[] roomVersion {  get; set; }
        
        
       

    }
}
