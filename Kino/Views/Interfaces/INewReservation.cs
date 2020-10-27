using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Views.Interfaces
{
    interface INewReservation
    {
        public Func<string> GetMovieTitle { get; set; }
        public Func<string> GetHallName { get; set; }
        public Func<DateTime> GetDate { get; set; }
        public Func<int[]> GetSeatsLocked { get; set; }
        public Action<int[]> ReserveSeats { get; set; }
    }
}
