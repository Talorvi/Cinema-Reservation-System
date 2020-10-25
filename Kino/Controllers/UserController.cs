#nullable enable
using System.Collections.Generic;
using System.Linq;
using Kino.Models;
using LinqToDB;

namespace Kino.Controllers
{
    public static class UserController
    {
        public static List<User> All()
        {
            using var db = new DbCinema();
            var query = from user in db.Users
                orderby user.Login descending
                select user;
            var users = query.ToList();
            return users;
        }

        public static User Get(int id)
        {
            using var db = new DbCinema();
            var query = from user in db.Users
                where user.Id == id
                select user;
            var singleUser = query.ToList()[0];
            return singleUser;
        }

        public static void Add(string login, string password, int role)
        {
            using var db = new DbCinema();
            db.Users
                .Value(user => user.Login, login)
                .Value(user => user.Password, password)
                .Value(user => user.Role, role)
                .Insert();
        }

        public static void Update(int id, string? login, string? password, int? role)
        {
            using var db = new DbCinema();
            var user = Get(id);

            if (login != null)
            {
                user.Login = login;
            }
            
            if (password != null)
            {
                user.Password = password;
            }
            
            if (role != null)
            {
                user.Role = (int) role;
            }

            db.Update(user);
        }
        
        public static void Delete(int id)
        {
            using var db = new DbCinema();
            db.Users
                .Where(user => user.Id == id)
                .Delete();
        }
    }
}