using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Views.Interfaces
{
    interface IWorkersList
    {
        public Action LoadWorkersList { get; set; }
        public Func<int> GetWorkersListCount { get; set; }
        public Action<int> ReadWorkerOnIndex { get; set; }
        public Func<string> GetWorkerUsername { get; set; }
        public Action<int> RemoveWorkerOnIndex { get; set; }
        public Action<int> EditWorkerOnIndex { get; set; }
        public Action MakeNewWorker { get; set; }
    }
}
