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
    public partial class RegisterView : AbstractChangingWindow, Interfaces.IRegister
    {
        private RegisterViewModel viewModel;
        public RegisterView()
        {
            InitializeComponent();
            viewModel = new RegisterViewModel(this);
        }

        public Func<string, string, bool> IsRegistrationValid { get; set; }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Change_Window(new LoginView());
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var pass = textBoxPassword.Text;
            var conf = textBoxConfirmPassword.Text;
            if (pass == conf)
            {
                if (IsRegistrationValid(login, pass))
                {
                    Change_Window(new LoginView());
                }
                else MessageBox.Show("Nie udało się zarejestrować.");
            }
            else MessageBox.Show("Hasła do siebie nie pasują.");
        }
    }
}
