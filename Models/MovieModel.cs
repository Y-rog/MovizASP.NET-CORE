namespace Moviz.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public int ReleaseDate { get; set; }

        ICollection<DirectorModel> Directors { get; set; }
        ICollection<GenreModel> Genres { get; set; }

    }
}
