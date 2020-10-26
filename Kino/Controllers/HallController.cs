#nullable enable
using System.Collections.Generic;
using System.Linq;
using Kino.Models;
using LinqToDB;

namespace Kino.Controllers
{
    public static class HallController
    {
        public static List<Hall> All()
        {
            using var db = new DbCinema();
            var query = from hall in db.Halls
                orderby hall.Name descending
                select hall;
            var halls = query.ToList();
            return halls;
        }

        public static Hall Get(int id)
        {
            using var db = new DbCinema();
            var query = from hall in db.Halls
                where hall.Id == id
                select hall;
            var singleHall = query.ToList()[0];
            return singleHall;
        }

        public static void Add(string name)
        {
            using var db = new DbCinema();
            db.Halls
                .Value(hall => hall.Name, name)
                .Insert();
        }

        public static void Update(int id, string? name)
        {
            using var db = new DbCinema();
            var hall = Get(id);

            if (name != null)
            {
                hall.Name = name;
            }

            db.Update(hall);
        }
        
        public static void Delete(int id)
        {
            using var db = new DbCinema();
            db.Halls
                .Where(hall => hall.Id == id)
                .Delete();
        }
    }
}