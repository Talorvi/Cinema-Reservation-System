using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Views.Interfaces
{
    interface IHall
    {
        public Action<string> SetHallName { get; set; }
        public Action SaveHall { get; set; }
    }
}
