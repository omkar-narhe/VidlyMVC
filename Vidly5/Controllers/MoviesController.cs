using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly5.Models;
using System.Data.Entity;
using Vidly5.ViewModels;

namespace Vidly5.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre);
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
        public ActionResult ByReleaseDate(int year, byte month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Details(int Id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == Id);
            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
        public ActionResult Edit(int Id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == Id);
            if (movie == null)
                return HttpNotFound();

            var viewModel = new AddEditMovieViewModel(movie)
            {
                Genre = _context.Genre.ToList()                
            };

            return View("MovieForm", viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(AddEditMovieViewModel viewModel)
        {
            if (viewModel.Id == 0)
            {
                Movies movieToAdd = new Movies();
                movieToAdd.Name = viewModel.Name;
                movieToAdd.DateAdded = viewModel.DateAdded;
                movieToAdd.ReleaseDate = viewModel.ReleaseDate;
                movieToAdd.NumberInStocks = (int)viewModel.NumberInStocks;

                _context.Movies.Add(movieToAdd);
            }
                
            else
            {
                var movieindb = _context.Movies.Single(m => m.Id == viewModel.Id);
                movieindb.Name = viewModel.Name;
                movieindb.ReleaseDate = viewModel.ReleaseDate;
                movieindb.DateAdded = viewModel.DateAdded;
                movieindb.NumberInStocks = (int)viewModel.NumberInStocks;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }

        public ViewResult New()
        {
            var genres = _context.Genre.ToList();

            var viewModel = new AddEditMovieViewModel
            {
                Genre = genres
            };

            return View("MovieForm", viewModel);
        }

    }
}