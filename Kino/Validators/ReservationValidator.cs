using Kino.Controllers;
using Kino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Validators
{
    class ReservationValidator
    {

        public static List<Reservation> GetAllReservations()
        {
            try
            {
                return ReservationController.All();
            }
            catch (Exception e)
            {
                return new List<Reservation>();
            }
        }

        public static Reservation GetReservationById(int id)
        {
            try
            {
                return ReservationController.Get(id);
            }
            catch (Exception e)
            {
                return new Reservation();
            }
        }

        public static Reservation GetReservationByUserIdAndSeanceId(int userId, int seanceId)
        {
            try
            {
                return ReservationController.GetByUserIdAndSeanceId(userId, seanceId);
            }
            catch (Exception e)
            {
                return new Reservation();
            }
        }

        public bool ReservationAddValidation(int? userId = null, int? seanceId = null, int? seat = null, bool isConfirmed = false)
        {
            try
            {
                if (userId == null || seanceId == null || ReservationController.GetByUserIdAndSeanceId(userId.Value, seanceId.Value) == null)
                {
                    return false;
                }
                ReservationController.Add(userId.Value, seanceId.Value, seat.Value, isConfirmed);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool ReservationUpdateValidation(int id, int seat, bool isConfirmed)
        {
            try
            {
                ReservationController.Update(id, seat, isConfirmed);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool ReservationDeleteValidation(int id)
        {
            try
            {
                ReservationController.Delete(id);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
