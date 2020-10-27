using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Views.Interfaces
{
    interface ISeance
    {
        public Func<string[]> GetHallsArray { get; set; }
        public Func<string[]> GetMoviesArray { get; set; }
        public Action<string> SetHall { get; set; }
        public Action<string> SetMovie { get; set; }
        public Action<DateTime> SetDate { get; set; }
        public Action SaveSeance { get; set; }
    }
}
