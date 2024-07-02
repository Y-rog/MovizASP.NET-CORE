namespace Moviz.Models
{
    public class GenreModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        ICollection<MovieModel> Movies { get; set; }
    }
}
