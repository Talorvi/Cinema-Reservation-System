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
    class ReserveViewModel
    {
        public ReserveViewModel(INewReservation view)
        {
            view.GetDate += GetDate;
            view.GetHallName += GetHallName;
            view.GetMovieTitle += GetMovieTitle;
            view.GetSeatsLocked += GetSeatsLocket;
            view.ReserveSeats += ReserveSeats;
            Cache.WsClient.Unlock += view.Unlock;
        }

        private void ReserveSeats(int[] obj)
        {
            foreach(var x in obj)
                Validators.ReservationValidator.ReservationAddValidation(Cache.User.Id,Cache.Seance.Id,x,false);
        }

        private int[] GetSeatsLocket()
        {
            var res = Validators.ReservationValidator.GetReservationBySeanceId(Cache.Seance.Id);
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
            return res.Select(x=>x.Seat).ToArray();
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
