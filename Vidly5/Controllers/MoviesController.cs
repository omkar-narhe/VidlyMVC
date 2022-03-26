using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly5.Models;
using Vidly5.ViewModels;

namespace Vidly5.Controllers
{
    public class MoviesController : Controller
    {

        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movies() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer{Id = 1, Name = "Williams"},
                new Customer{Id = 2, Name = "Kelly"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movies = movie,
                Customers = customers
            };
            return View(viewModel);
        }
        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate (int year, byte month)
        {
            return Content(year + "/" + month);
        }

        public IEnumerable<Movies> GetMovies()
        {
            return new List<Movies>()
            {
                new Movies{Id = 1, Name = "Shrek!"},
                new Movies{Id = 2, Name = "Harry Potter"}
            };
        }
    }
}