using System;

namespace Kino.Views.Interfaces
{
    interface IWorker
    {
        public Action<string> SetWorkerPassword { get; set; }
        public Action SaveWorker { get; set; }
    }
}
