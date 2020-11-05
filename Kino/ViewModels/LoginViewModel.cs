using Kino.Models;
using Kino.Utilities;
using Kino.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.ViewModels
{
    class LoginViewModel
    {
        public LoginViewModel(ILogin view)
        {
            view.IsLoginValid += IsLoginValid;
            view.IsWorker += IsWorker;
        }

        private bool IsLoginValid(string user, string pass)
        {
            return Validators.UserValidator.UserLoginValidation(user, pass);
        }
        private bool IsWorker(string user)
        {
            var tmp = Validators.UserValidator.GetUserByLogin(user);
            Cache.User = tmp;
            if(tmp.Role.Name == "user")
            {
                return false;
            }
            return true;
        }
    }
}
