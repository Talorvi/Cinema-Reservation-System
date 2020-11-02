using System;

namespace Kino.Views.Interfaces
{
    interface IWorker
    {
        public Func<string> GetWorkerUsername { get; set; }
        public Action<string> SetWorkerUsername { get; set; }
        public Action SaveWorker { get; set; }
    }
}
