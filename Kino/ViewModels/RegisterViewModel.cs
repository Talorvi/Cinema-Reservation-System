using Kino.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.ViewModels
{
    class RegisterViewModel
    {
        public RegisterViewModel(IRegister view)
        {
            view.IsRegistrationValid += IsRegistrationValid;
        }

        private bool IsRegistrationValid(string user, string pass)
        {
            return Validators.UserValidator.UserAddValidation(user, pass);
        }
    }
}
