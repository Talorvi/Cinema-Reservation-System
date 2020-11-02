using Kino.Utilities;
using Kino.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.ViewModels
{
    class WorkerListViewModel
    {
        public WorkerListViewModel(IWorkersList view)
        {
            view.EditWorkerOnIndex += EditWorker;
            view.GetWorkersListCount += GetCount;
            view.GetWorkerUsername += GetUsername;
            view.LoadWorkersList += LoadList;
            view.MakeNewWorker += MakeNew;
            view.ReadWorkerOnIndex += ReadWorker;
            view.RemoveWorkerOnIndex += Remove;
        }

        private void Remove(int id)
        {
            Validators.UserValidator.UserUpdateValidation(Cache.Worker.Id,null,3);
        }

        private void ReadWorker(int id)
        {
            Cache.Worker = Cache.Workers[id];
        }

        private void MakeNew()
        {
            Cache.Worker = new Models.User();
        }

        private void LoadList()
        {
            Cache.Workers = Validators.UserValidator.GetAllUsers().Where(x => x.RoleId != 3).ToList();
        }

        private string GetUsername()
        {
            return Cache.Worker.Login;
        }

        private int GetCount()
        {
            return Cache.Workers.Count();
        }

        private void EditWorker(int id)
        {

        }
    }
}
