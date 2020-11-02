using Kino.Utilities;
using Kino.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.ViewModels
{
    class ReserveViewModel
    {
        public ReserveViewModel(INewReservation view)
        {
            view.GetDate += GetDate;
            view.GetHallName += GetHallName;
            view.GetMovieTitle += GetMovieTitle;
            view.GetSeatsLocked += GetSeatsLocket;
            view.ReserveSeats += ReserveSeats;
        }

        private void ReserveSeats(int[] obj)
        {
            foreach(var x in obj)
                Validators.ReservationValidator.ReservationAddValidation(Cache.User.Id,Cache.Seance.Id,x,false);
        }

        private int[] GetSeatsLocket()
        {
            Validators.ReservationValidator.GetAllReservations();
        }

        private string GetMovieTitle()
        {
            return Cache.Seance.Movie.Name;
        }

        private string GetHallName()
        {
            return Cache.Seance.Hall.Name;
        }

        private DateTime GetDate()
        {
            return Cache.Seance.Time;
        }
    }
}
