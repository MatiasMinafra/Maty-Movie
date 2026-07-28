namespace Maty_Movie.Models
{
    public class Plataforma
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Url { get; set; }
        public string LogoUrl { get; set; }

        public List<Pelicula>? PeliculaPlataforma { get; set; }
    }
}
