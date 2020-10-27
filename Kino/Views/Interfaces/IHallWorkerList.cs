using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Views.Interfaces
{
    interface IHallWorkerList
    {
        public Action LoadHallsList { get; set; }
        public Func<int> GetHallsListCount { get; set; }
        public Action<int> ReadHallOnIndex { get; set; }
        public Func<string> GetHallName { get; set; }
        public Action<int> RemoveHallOnIndex { get; set; }
        public Action<int> EditHallOnIndex { get; set; }
        public Action MakeNewHallObject { get; set; }
    }
}
