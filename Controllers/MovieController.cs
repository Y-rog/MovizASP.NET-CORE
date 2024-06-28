using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Moviz.Models;

namespace Moviz.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            // Créer un film
            List<MovieModel> allMovies = new ()
            {
                new MovieModel {
                Id = 1,
                Name = "Le seigneur des anneaux : la communauté de l'anneau",
                ReleaseDate = new DateTime(2001)
                },
                new MovieModel {
                Id = 2,
                Name = "Le seigneur des anneaux : les deux tours",
                ReleaseDate = new DateTime(2002)
                },
                new MovieModel {
                Id = 3,
                Name = "Le seigneur des anneaux : le retour du roi",
                ReleaseDate = new DateTime(2003)
                },
            };

            //Vue Views/Movie/index.cshtml et donne lui l'objet myFilm
            return View(nameof(Index), allMovies);
        }
    }
}
