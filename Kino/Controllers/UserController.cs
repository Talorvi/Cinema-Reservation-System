#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using Kino.Models;
using Kino.Utilities;
using LinqToDB;

namespace Kino.Controllers
{
    /*
     * TODO: Add validation and Caesar cypher
     */
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

        /*
         * TODO: Add validation while looking for role
         */
        public static User Get(int id)
        {
            using var db = new DbCinema();
            var queryable = from user in db.Users
                where user.Id == id
                join role in db.Roles on user.RoleId equals role.Id
                select User.Build(user, role);

            var singleUser = queryable.ToList()[0];
            return singleUser;
        }

        public static User GetByLogin(string login)
        {
            using var db = new DbCinema();
            var queryable = from user in db.Users
                            where user.Login == login
                            join role in db.Roles on user.RoleId equals role.Id
                            select User.Build(user, role);

            var singleUser = queryable.ToList()[0];
            return singleUser;
        }

        /*
         * Default role is user
         * 1 - admin
         * 2 - employee
         * 3 - user
         */
        public static void Add(string login, string password, int roleId = 3)
        {
            using var db = new DbCinema();
            db.Users
                .Value(user => user.Login, login)
                .Value(user => user.Password, PasswordCipher.ConvertPassword(password))
                .Value(user => user.RoleId, roleId)
                .Insert();
        }

        public static void Update(int id, string? password = null, int? roleId = null)
        {
            using var db = new DbCinema();
            var user = Get(id);

            if (password != null)
            {
                user.Password = PasswordCipher.ConvertPassword(password);
            }
            
            if (roleId != null)
            {
                user.RoleId = (int) roleId;
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

        public static List<Reservation> GetReservations(int id)
        {
            using var db = new DbCinema();
            var queryable = from reservation in db.Reservations
                where reservation.UserId == id
                join user in db.Users on reservation.UserId equals user.Id
                select reservation;

            return queryable.ToList().Select(reservation => ReservationController.Get(reservation.Id)).ToList();
        }

        public static bool Login(string login, string password)
        {
            using var db = new DbCinema();
            string encodedPassword = PasswordCipher.ConvertPassword(password);
            var queryable = from user in db.Users
                where user.Login == login && user.Password == encodedPassword
                select user;

            return queryable.ToList().Count > 0;
        }
    }
}