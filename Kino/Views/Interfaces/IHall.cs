using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Views.Interfaces
{
    interface IHall
    {
        public Func<string> GetHallName { get; set; }
        public Action<string> SetHallName { get; set; }
        public Action SaveHall { get; set; }
    }
}
