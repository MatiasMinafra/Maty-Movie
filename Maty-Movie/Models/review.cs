namespace Maty_Movie.Models
{
    public class review
    {
        public int Id { get; set; }
        public int PeliculaId { get; set; }
        public Pelicula? pelicula { get; set; }
        public string UsuarioId { get; set; }

        public Usuario? usuario { get; set; }

        public int Rating { get; set; }
        public string Comentario { get; set; }
        
        public DateTime FechaReview { get; set; }
        
        
       

    }
}
