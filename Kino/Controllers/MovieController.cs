#nullable enable
using System.Collections.Generic;
using System.Linq;
using Kino.Models;
using LinqToDB;

namespace Kino.Controllers
{
    public static class MovieController
    {
        public static List<Movie> All()
        {
            using var db = new DbCinema();
            var query = from movie in db.Movies
                orderby movie.Name descending
                select movie;
            var movies = query.ToList();
            return movies;
        }

        public static Movie Get(int id)
        {
            using var db = new DbCinema();
            var query = from movie in db.Movies
                where movie.Id == id
                select movie;
            var singleMovie = query.ToList()[0];
            return singleMovie;
        }

        public static Movie GetByName(string name)
        {
            using var db = new DbCinema();
            var query = from movie in db.Movies
                where movie.Name == name
                select movie;
            var singleMovie = query.ToList()[0];
            return singleMovie;
        }

        public static void Add(string name, double length)
        {
            using var db = new DbCinema();
            db.Movies
                .Value(movie => movie.Name, name)
                .Value(movie => movie.Length, length)
                .Insert();
        }

        public static void Update(int id, string? name, double? length)
        {
            using var db = new DbCinema();
            var movie = Get(id);

            if (name != null)
            {
                movie.Name = name;
            }

            if (length != null)
            {
                movie.Length = (double) length;
            }

            db.Update(movie);
        }
        
        public static void Delete(int id)
        {
            using var db = new DbCinema();
            db.Movies
                .Where(movie => movie.Id == id)
                .Delete();
        }
    }
}