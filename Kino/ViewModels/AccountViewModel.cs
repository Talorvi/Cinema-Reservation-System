using Kino.Models;
using Kino.Utilities;
using Kino.Views.Interfaces;
using Renci.SshNet.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino.ViewModels
{
    class AccountViewModel
    {
        public AccountViewModel(IAccount view)
        {
            view.CheckOldPassword += CheckOldPassword;
            view.SetNewPassword += SetNewPassword;
            view.SaveAccount += SaveAccount;

        }

        private void SaveAccount()
        {
            
        }

        private void SetNewPassword(string pass)
        {
            if (Validators.UserValidator.UserUpdateValidation(Cache.User.Id, pass, Cache.User.RoleId))
                MessageBox.Show("Pomyślnie zmieniono hasło.");
        }

        private bool CheckOldPassword(string pass)
        {
            return Validators.UserValidator.UserLoginValidation(Cache.User.Login,pass);
        }
    }
}
