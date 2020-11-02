using Kino.Utilities;
using Kino.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.ViewModels
{
    class PickSeanceViewModel
    {
        public PickSeanceViewModel(ISeancesList view)
        {
            view.GetSeanceDate += GetSeanceDate;
            view.GetSeancesListCount += GetSeancesListCount;
            view.GetSeanceTitle += GetSeancesTitle;
            view.LoadSenacesList += LoadSeancesList;
            view.MakeSeanceReservationOnIndex += MakeReservation;
            view.ReadSeanceOnIndex += ReadSeance;
        }

        private void ReadSeance(int id)
        {
            Cache.Seance = Cache.Seances[id];
        }

        private void MakeReservation(int id)
        {
            Cache.Seance = Cache.Seances[id];
        }

        private void LoadSeancesList()
        {
            Cache.Seances = Validators.SeanceValidator.GetAllSeances();
        }

        private string GetSeancesTitle()
        {
            return Cache.Seance.Movie.Name;
        }

        private int GetSeancesListCount()
        {
            return Cache.Seances.Count;
        }

        private DateTime GetSeanceDate()
        {
            return Cache.Seance.Time;
        }
    }
}
