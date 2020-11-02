using Kino.Utilities;
using Kino.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.ViewModels
{
    class HallsViewModel
    {
        public HallsViewModel(IHallWorkerList view)
        {
            view.EditHallOnIndex += editHall;
            view.GetHallName += GetHallName;
            view.GetHallsListCount += GetCount;
            view.LoadHallsList += LoadList;
            view.MakeNewHallObject += MakeNew;
            view.ReadHallOnIndex += ReadHall;
            view.RemoveHallOnIndex += RemoveHall;
        }

        private void RemoveHall(int id)
        {
            Validators.HallValidator.HallDeleteValidation(Cache.Halls[id].Id);
        }

        private void ReadHall(int id)
        {
            Cache.Hall = Cache.Halls[id];
        }

        private void MakeNew()
        {
            Cache.Hall = new Models.Hall();
        }

        private void LoadList()
        {
            Cache.Halls = Validators.HallValidator.GetAllHalls();
        }

        private int GetCount()
        {
            return Cache.Halls.Count();
        }

        private string GetHallName()
        {
            return Cache.Hall.Name;
        }

        private void editHall(int id)
        {
            Cache.Hall = Cache.Halls[id];
        }
    }
}
