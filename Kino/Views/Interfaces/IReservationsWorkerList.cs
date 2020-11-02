using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Views.Interfaces
{
    interface IReservationsWorkerList
    {
        public Action LoadReservationsList { get; set; }
        public Func<int> GetReservationListCount { get; set; }
        public Action<int> ReadReservationOnIndex { get; set; }
        public Func<string> GetReservationUser { get; set; }
        public Func<string> GetMovieTitle { get; set; }
        public Func<string> GetHallName { get; set; }
        public Func<int> GetSeatNumber { get; set; }
        public Func<DateTime> GetDate { get; set; }
        public Func<bool> GetConfirmation { get; set; }
    }
}
