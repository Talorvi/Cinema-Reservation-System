using Kino.Models;
using Kino.Utilities;
using Kino.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.ViewModels
{
    class ReservationsViewModel
    {
        public ReservationsViewModel(IReservationsWorkerList view)
        {
            view.GetConfirmation += GetConfirmation;
            view.GetDate += GetDate;
            view.GetHallName += GetHallName;
            view.GetMovieTitle += GetMovieTitle;
            view.GetReservationListCount += Getcount;
            view.GetReservationUser += GetUser;
            view.GetSeatNumber += GetSeat;
            view.LoadReservationsList += LoadList;
            view.ReadReservationOnIndex += ReadIndex;
        }

        private void ReadIndex(int id)
        {
            Cache.Reservation = Cache.Reservations[id];
        }

        private void LoadList()
        {
            var res = Validators.ReservationValidator.GetAllReservations();
            var invalid = new List<Reservation>();
            foreach (var x in res)
            {
                if (x.Time.AddMinutes(15) < DateTime.Now && !x.IsConfirmed)
                {
                    Validators.ReservationValidator.ReservationDeleteValidation(x.Id);
                    invalid.Add(x);
                }
            }
            res.RemoveAll(x => invalid.Contains(x));
            Cache.Reservations = res;
        }

        private int GetSeat()
        {
            return Cache.Reservation.Seat;
        }

        private string GetUser()
        {
            return Cache.Reservation.User.Login;
        }

        private int Getcount()
        {
            return Cache.Reservations.Count();
        }

        private string GetMovieTitle()
        {
            return Cache.Reservation.Seance.Movie.Name;
        }

        private string GetHallName()
        {
            return Cache.Reservation.Seance.Hall.Name;
        }

        private DateTime GetDate()
        {
            return Cache.Reservation.Seance.Time;
        }

        private bool GetConfirmation()
        {
            return Cache.Reservation.IsConfirmed;
        }
    }
}
