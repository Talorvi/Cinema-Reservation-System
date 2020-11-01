using Kino.Controllers;
using Kino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Validators
{
    class MovieValidator
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

        public bool MovieAddValidation(string name, double length)
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

        public bool MovieUpdateValidation(int id, string name, double length)
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

        public bool MovieDeleteValidation(int id)
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
