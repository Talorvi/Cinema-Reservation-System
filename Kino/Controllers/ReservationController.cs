using System;
using System.Collections.Generic;
using System.Linq;
using Kino.Models;
using LinqToDB;

namespace Kino.Controllers
{
    public static class ReservationController
    {
        public static List<Reservation> All()
        {
            using var db = new DbCinema();
            var query = from reservation in db.Reservations
                        join user in db.Users on reservation.UserId equals user.Id
                        join seance in db.Seances on reservation.SeanceId equals seance.Id
                        orderby reservation.Id descending
                        select Reservation.Build(reservation,user,seance);

            var reservations = query.ToList(); 
            foreach(var res in reservations)
            {
                res.Seance = SeanceController.Get(res.SeanceId);
                res.User = UserController.Get(res.UserId);
            }
            return reservations;
        }
        
        public static Reservation Get(int id)
        {
            using var db = new DbCinema();
            var queryable = from reservation in db.Reservations
                join user in db.Users on reservation.UserId equals user.Id
                join seance in db.Seances on reservation.SeanceId equals seance.Id
                where reservation.Id == id
                select Reservation.Build(reservation, user, seance);

            var singleReservation = queryable.ToList()[0];
            singleReservation.Seance = SeanceController.Get(singleReservation.SeanceId);
            singleReservation.User = UserController.Get(singleReservation.UserId);
            return singleReservation;
        }
        
        public static Reservation GetByUserIdAndSeanceId(int userId, int seanceId)
        {
            using var db = new DbCinema();
            var queryable = from reservation in db.Reservations
                join user in db.Users on reservation.UserId equals user.Id
                join seance in db.Seances on reservation.SeanceId equals seance.Id
                where reservation.UserId == userId && reservation.SeanceId == seanceId
                select Reservation.Build(reservation, user, seance);

            var singleReservation = queryable.ToList()[0];
            singleReservation.Seance = SeanceController.Get(singleReservation.SeanceId);
            singleReservation.User = UserController.Get(singleReservation.UserId);
            return singleReservation;
        }
        
        public static List<Reservation> GetBySeanceId(int seanceId)
        {
            using var db = new DbCinema();
            var queryable = from reservation in db.Reservations
                join seance in db.Seances on reservation.SeanceId equals seance.Id
                where reservation.SeanceId == seanceId
                select Reservation.Build(reservation, seance);

            var reservations = queryable.ToList();
            return reservations;
        }
        
        public static void Add(int userId, int seanceId, int seat, DateTime time, bool isConfirmed = false)
        {
            using var db = new DbCinema();
            db.Reservations
                .Value(reservation => reservation.UserId, userId)
                .Value(reservation => reservation.SeanceId, seanceId)
                .Value(reservation => reservation.Seat, seat)
                .Value(reservation => reservation.IsConfirmed, isConfirmed)
                .Value(reservation => reservation.Time, time)
                .Insert();
        }

        public static void Update(int id, int? seat = null, bool? isConfirmed = null)
        {
            using var db = new DbCinema();
            var reservation = Get(id);

            if (seat != null)
            {
                reservation.Seat = (int) seat;
            }
            
            if (isConfirmed != null)
            {
                reservation.IsConfirmed = (bool) isConfirmed;
            }

            db.Update(reservation);
        }
        
        public static void Delete(int id)
        {
            using var db = new DbCinema();
            db.Reservations
                .Where(reservation => reservation.Id == id)
                .Delete();
        }
    }
}