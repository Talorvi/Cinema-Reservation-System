using Kino.Controllers;
using Kino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Validators
{
    class SeanceValidator
    {

        public static List<Seance> GetAllSeances()
        {
            try
            {
                return SeanceController.All();
            }
            catch (Exception e)
            {
                return new List<Seance>();
            }
        }

        public static Seance GetSeanceById(int id)
        {
            try
            {
                return SeanceController.Get(id);
            }
            catch (Exception e)
            {
                return new Seance();
            }
        }

        public bool SeanceAddValidation(int movieId, int hallId, DateTime time)
        {
            try
            {
                SeanceController.Add(movieId, hallId, time);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SeanceUpdateValidation(int id, int movieId, int hallId, DateTime time)
        {
            try
            {
                SeanceController.Update(id, movieId, hallId, time);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SeanceDeleteValidation(int id)
        {
            try
            {
                SeanceController.Delete(id);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
