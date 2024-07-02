namespace Moviz.Models
{
    public class DirectorModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        ICollection<MovieModel> Movies { get; set; }
    }
}
