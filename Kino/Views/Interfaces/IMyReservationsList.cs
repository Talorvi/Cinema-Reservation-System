using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Views.Interfaces
{
    interface IMyReservationsList
    {
        public Action LoadReservationsList { get; set; }
        public Func<int> GetReservationListCount { get; set; }
        public Action<int> ReadReservationOnIndex { get; set; }
        public Func<string> GetMovieTitle { get; set; }
        public Func<int> GetSeatNumber { get; set; }
        public Func<DateTime> GetDate { get; set; }
        public Action ConfirmReservation { get; set; }

    }
}
