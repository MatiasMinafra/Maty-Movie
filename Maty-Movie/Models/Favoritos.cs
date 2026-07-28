namespace Maty_Movie.Models
{
    public class Favoritos
    {
       public int UsuarioId {  get; set; }
        public Usuario? usuario { get; set; }
       public string PeliculaId { get; set; }
        public Pelicula? pelicula { get; set; }

        public DateTime Fecha { get; set; }
    }
}
