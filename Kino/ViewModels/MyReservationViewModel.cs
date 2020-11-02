using Kino.Utilities;
using Kino.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.ViewModels
{
    class MyReservationViewModel
    {
        public MyReservationViewModel(IMyReservationsList view)
        {
            view.ConfirmReservationAtIndex += ConfirmReservationAtIndex;
            view.GetConfirmation += GetConfirmation;
            view.GetDate += GetDate;
            view.GetHallName += GetHallName;
            view.GetMovieTitle += GetMovieTitle;
            view.GetReservationListCount += GetReservationListCount;
            view.GetSeatNumber += GetSeatNumber;
            view.LoadReservationsList += LoadReservationList;
            view.ReadReservationOnIndex += ReadReservationOnIndex;
        }

        private void ReadReservationOnIndex(int id)
        {
            if(Cache.Reservations.Count > id)
                Cache.Reservation = Cache.Reservations[id];
        }

        private void LoadReservationList()
        {
            Cache.Reservations = Validators.UserValidator.GetUserReservations(Cache.User.Id);
        }

        private int GetSeatNumber()
        {
            return Cache.Reservation.Seat;
        }

        private int GetReservationListCount()
        {
            return Cache.Reservations.Count;
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

        private void ConfirmReservationAtIndex(int id)
        {
            Validators.ReservationValidator.ReservationUpdateValidation(Cache.Reservations[id].Id, Cache.Reservations[id].Seat,true);
        }
    }
}
