using Kino.Utilities;
using Kino.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.ViewModels
{
    class WorkerViewModel
    {
        public WorkerViewModel(IWorker view)
        {
            view.GetWorkerUsername += GetUsername;
            view.SetWorkerUsername += SetUsername;
            view.SaveWorker += Save;
        }

        private void Save()
        {

        }

        private void SetUsername(string name)
        {
            Cache.Worker.Login = name;
        }

        private string GetUsername()
        {
            return Cache.Worker.Login;
        }
    }
}
