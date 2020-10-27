using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Views.Interfaces
{
    interface ISeancesList
    {
        public Action LoadSenacesList { get; set; }
        public Func<int> GetSeancesListCount { get; set; }
        public Action<int> ReadSeanceOnIndex { get; set; }
        public Func<string> GetSeanceTitle { get; set; }
        public Func<DateTime> GetSeanceDate { get; set; }
        public Func<string> GetHallName { get; set; }
        public Action<int> MakeSeanceReservationOnIndex { get; set; }
    }
}
