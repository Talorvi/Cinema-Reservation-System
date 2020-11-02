using Kino.Utilities;
using Kino.Validators;
using Kino.Views.Interfaces;

namespace Kino.ViewModels
{
    class HallViewModel
    {
        private IHall view;
        public HallViewModel(IHall view)
        {
            this.view = view;
            view.SaveHall += SaveHall;
            view.GetHallName += GetHallName;
            view.SetHallName += SetHallName;
        }

        private void SaveHall()
        {
            if (Cache.Hall.Id != 0)
            {
                HallValidator.HallUpdateValidation(Cache.Hall.Id, Cache.Hall.Name);
            }
            else
            {
                HallValidator.HallAddValidation(Cache.Hall.Name);
            }
        }

        private string GetHallName()
        {
            return Cache.Hall.Name;
        }

        private void SetHallName(string name)
        {
            Cache.Hall.Name = name;
        }
    }
}