namespace Maty_Movie.Models
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string ImagenUrlPerfil { get; set; }

       public List <Favoritos>? PeliculasFavoritas { get; set; }



    }
}
