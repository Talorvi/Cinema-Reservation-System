using Kino.Controllers;
using Kino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Validators
{
    public static class MovieValidator
    {

        public static List<Movie> GetAllMovies()
        {
            try
            {
                return MovieController.All();
            }
            catch (Exception e)
            {
                return new List<Movie>();
            }
        }

        public static Movie GetMovieById(int id)
        {
            try
            {
                return MovieController.Get(id);
            }
            catch (Exception e)
            {
                return new Movie();
            }
        }

        public static Movie GetMovieByName(string name)
        {
            try
            {
                return MovieController.GetByName(name);
            }
            catch (Exception e)
            {
                return new Movie();
            }
        }

        public static bool MovieAddValidation(string name, double length)
        {
            try
            {
                MovieController.Add(name, length);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool MovieUpdateValidation(int id, string name, double length)
        {
            try
            {
                MovieController.Update(id, name, length);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool MovieDeleteValidation(int id)
        {
            try
            {
                MovieController.Delete(id);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
