using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Moviz.Models;

namespace Moviz.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MovieModel>Movies { get; set; }
        public DbSet<DirectorModel> Directors { get; set; }
        public DbSet<GenreModel> Genres { get; set; }
        public DbSet<ReviewModel> Reviews { get; set; }
    }
}
