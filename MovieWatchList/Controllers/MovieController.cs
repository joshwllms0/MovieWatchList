using Microsoft.AspNetCore.Mvc;
using MovieWatchList.Models;
using MovieWatchList.Services;

namespace MovieWatchList.Controllers
{
    public class MovieController : Controller
    {
        // Show all movies
        public IActionResult Index()
        {
            var movies = MovieService.GetAll();
            return View(movies);
        }

        // Show the form
        public IActionResult Create()
        {
            return View();
        }

        // Handle the form submission
        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                MovieService.Add(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        // Toggle Watched
        public IActionResult ToggleWatched(int id)
        {
            MovieService.ToggleWatched(id);
            return RedirectToAction("Index");
        }

        // Delete Movie
        public IActionResult Delete(int id)
        {
            MovieService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
