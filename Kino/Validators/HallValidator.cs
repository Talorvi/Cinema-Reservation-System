using Google.Protobuf.Collections;
using Kino.Controllers;
using Kino.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Validators
{
    class HallValidator
    {

        public static List<Hall> GetAllHalls()
        {
            try
            {
                return HallController.All();
            }
            catch (Exception e)
            {
                return new List<Hall>();
            }
        }

        public static Hall GetHallById(int id)
        {
            try
            {
                return HallController.Get(id);
            }
            catch (Exception e)
            {
                return new Hall();
            }
        }

        public static Hall GetHallByName(string name)
        {
            try
            {
                return HallController.GetByName(name);
            }
            catch (Exception e)
            {
                return new Hall();
            }
        }

        public bool HallAddValidation(string name)
        {
            try
            {
                if (name == null || HallController.GetByName(name) != null)
                {
                    return false;
                }
                HallController.Add(name);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool HallUpdateValidation(int id, string name)
        {
            try
            {
                HallController.Update(id, name);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool HallDeleteValidation(int id)
        {
            try
            {
                HallController.Delete(id);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
