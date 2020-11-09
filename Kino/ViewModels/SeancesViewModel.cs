using Kino.Utilities;
using Kino.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.ViewModels
{
    class SeancesViewModel
    {
        public SeancesViewModel(ISeancesWorkerList view)
        {
            view.EditSeanceOnIndex += EditSeance;
            view.GetHallName += GetHallName;
            view.GetSeanceDate += GetSeanceDate;
            view.GetSeancesListCount += GetCount;
            view.GetSeanceTitle += GetTitle;
            view.LoadSenacesList += LoadList;
            view.MakeNewSeanceObject += MakeNew;
            view.ReadSeanceOnIndex += ReadSeance;
            view.RemoveSeanceOnIndex += RemoveSeance;
        }

        private void RemoveSeance(int id)
        {
            Validators.SeanceValidator.SeanceDeleteValidation(Cache.Seances[id].Id);
        }

        private void ReadSeance(int id)
        {
            Cache.Seance = Cache.Seances[id];
        }

        private void MakeNew()
        {
            var seance = new Models.Seance();
            seance.Hall = new Models.Hall();
            seance.Movie = new Models.Movie();
            Cache.Seance = seance;
        }

        private void LoadList()
        {
            Cache.Seances = Validators.SeanceValidator.GetAllSeances();
        }

        private string GetTitle()
        {
            return Cache.Seance.Movie.Name;
        }

        private int GetCount()
        {
            return Cache.Seances.Count();
        }

        private DateTime GetSeanceDate()
        {
            return Cache.Seance.Time;
        }

        private string GetHallName()
        {
            return Cache.Seance.Hall.Name;
        }

        private void EditSeance(int id)
        {
            Cache.Seance = Cache.Seances[id];
        }
    }
}
