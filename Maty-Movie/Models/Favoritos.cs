namespace Maty_Movie.Models
{
    public class Favoritos
    {
        public int Id { get; set; }
       public string UsuarioId {  get; set; }
        public Usuario? usuario { get; set; }
       public int PeliculaId { get; set; }
        public Pelicula? pelicula { get; set; }

        public DateTime Fecha { get; set; }
    }
}
