using Microsoft.AspNetCore.Mvc;
using MovieWatchList.Models;

namespace MovieWatchList.Services
{
    public class MovieService
    {
        private static List<Movie> _movies = new List<Movie>
        {
            new Movie
            {
                Id = 1,
                Title = "The Matrix",
                Year = 1999,
                Description = "A hacker discorer reality is a simulation",
                Watched = true
            },
            new Movie
            {
                Id = 2,
                Title = "Inception",
                Year = 2010,
                Description = "Dreams within another dream.",
                Watched = false
            },
            new Movie
            {
                Id = 3,
                Title = "Interstellar",
                Year = 2014,
                Description = "Space exploration... Time is relative.",
            }
        };

        private static int _nextId = 4;

        // Get all movies
        public static List<Movie> GetAll() => _movies;

        // Get movie by Id
        public static Movie? GetById(int id) => _movies.FirstOrDefault(m => m.Id == id);

        // Add a new movie
        public static void Add(Movie movie)
        {
            movie.Id = _nextId++;
            _movies.Add(movie);
        }

        // Toggle watch status
        public static void ToggleWatched(int id)
        {
            var movie = GetById(id);
            if (movie != null)
            {
                movie.Watched = !movie.Watched;
            }
        }

        // Delete a movie
        public static void Delete(int id)
        {
            var movie = GetById(id);
            if (movie != null)
            {
                _movies.Remove(movie);
            }
        }
    }
}
