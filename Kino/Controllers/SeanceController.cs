using System;
using System.Collections.Generic;
using System.Linq;
using Kino.Models;
using LinqToDB;

namespace Kino.Controllers
{
    public static class SeanceController
    {
        public static List<Seance> All()
        {
            using var db = new DbCinema();
            var query = from seance in db.Seances
                join movie in db.Movies on seance.MovieId equals movie.Id
                join hall in db.Halls on seance.HallId equals hall.Id
                select Seance.Build(seance, movie, hall);
            var seances = query.ToList();
            return seances;
        }
        
        public static Seance Get(int id)
        {
            using var db = new DbCinema();
            var queryable = from seance in db.Seances
                join movie in db.Movies on seance.MovieId equals movie.Id
                join hall in db.Halls on seance.HallId equals hall.Id
                where seance.Id == id
                select Seance.Build(seance, movie, hall);

            var singleSeance = queryable.ToList()[0];
            return singleSeance;
        }
        
        public static void Add(int movieId, int hallId, DateTime time)
        {
            using var db = new DbCinema();
            db.Seances
                .Value(seance => seance.MovieId, movieId)
                .Value(seance => seance.HallId, hallId)
                .Value(seance => seance.Time, time)
                .Insert();
        }

        public static void Update(int id, int? movieId = null, int? hallId = null, DateTime? time = null)
        {
            using var db = new DbCinema();
            var seance = Get(id);

            if (movieId != null)
            {
                seance.MovieId = (int) movieId;
            }
            
            if (hallId != null)
            {
                seance.HallId = (int) hallId;
            }

            if (time != null)
            {
                seance.Time = (DateTime) time;
            }

            db.Update(seance);
        }
        
        public static void Delete(int id)
        {
            using var db = new DbCinema();
            db.Seances
                .Where(seance => seance.Id == id)
                .Delete();
        }
    }
}