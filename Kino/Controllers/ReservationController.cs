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
                orderby reservation.Id descending
                select reservation;
            var reservations = query.ToList();
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
        
        public static void Add(int userId, int seanceId, int seat, bool isConfirmed = false)
        {
            using var db = new DbCinema();
            db.Reservations
                .Value(reservation => reservation.UserId, userId)
                .Value(reservation => reservation.SeanceId, seanceId)
                .Value(reservation => reservation.Seat, seat)
                .Value(reservation => reservation.IsConfirmed, isConfirmed)
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