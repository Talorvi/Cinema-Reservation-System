using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kino.ViewModels;

namespace Kino.Views
{
    public partial class AccountView : AbstractChangingWindow, Interfaces.IAccount
    {
        private AccountViewModel viewModel;
        public AccountView()
        {
            InitializeComponent();
            viewModel = new AccountViewModel(this);
        }

        public Func<string, bool> CheckOldPassword { get; set; }
        public Action<string> SetNewPassword { get; set; }
        public Action SaveAccount { get; set; }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var old = textBoxOldPassword.Text;
            var pass = textBoxNewPassword.Text;
            var conf = textBoxConfirmPassword.Text;
            if (pass == conf)
            {
                if (CheckOldPassword(old))
                {
                    SetNewPassword(pass);
                    SaveAccount();
                }
                else MessageBox.Show("Niepoprawne hasło.");
            }
            else MessageBox.Show("Hasła nie pasują do siebie.");
        }
    }
}
