using Kino.Controllers;
using Kino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Validators
{
    public static class UserValidator
    {

        public static List<User> GetAllUsers()
        {
            try
            {
                return UserController.All();
            }
            catch (Exception e)
            {
                return new List<User>();
            }
        }

        public static User GetUserById(int id)
        {
            try
            {
                return UserController.Get(id);
            }
            catch (Exception e)
            {
                return new User();
            }
        }

        public static User GetUserByLogin(string login)
        {
            try
            {
                return UserController.GetByLogin(login);
            }
            catch (Exception e)
            {
                return new User();
            }
        }

        public static bool UserAddValidation(string login, string password, int roleId = 3)
        {
            try
            {
                if (login == null || password == null || UserController.GetByLogin(login) != null)
                {
                    return false;
                }
                UserController.Add(login, password, roleId);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool UserUpdateValidation(int id, string password, int roleId)
        {
            try
            {
                UserController.Update(id, password, roleId);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool UserDeleteValidation(int id)
        {
            try
            {
                UserController.Delete(id);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static List<Reservation> GetUserReservations(int id)
        {
            try
            {
                return UserController.GetReservations(id);
            }
            catch (Exception e)
            {
                return new List<Reservation>();
            }
        }

        public static bool UserLoginValidation(string login, string password)
        {
            try
            {
                return UserController.Login(login, password);
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
