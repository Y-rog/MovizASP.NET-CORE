using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Moviz.Models
{
    public class ReviewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Review { get; set; }
        public bool IsValidated { get; set; }
        public int MovieId { get; set; }
        public string UserId { get; set; }


        public MovieModel Movie { get; set; }
        ICollection<IdentityUser> IdentityUsers { get; set; }



    }
}
