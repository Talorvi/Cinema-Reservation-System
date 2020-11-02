﻿using System;
using System.Windows.Forms;

namespace Kino.Views
{
    public partial class LoginView : AbstractChangingWindow, Interfaces.ILogin
    {
        public Func<string, string, bool> IsLoginValid { get; set; }
        public Func<bool> IsWorker { get; set; }

        public LoginView()
        {
            InitializeComponent();
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Change_Window(new RegisterView());
        }

        private void buttonLogin_Click(object sender, System.EventArgs e)
        {
            var login = textBoxLogin.Text;
            var pass = textBoxPassword.Text;
            if (IsLoginValid(login, pass))
            {
                if (IsWorker()) Change_Window(new WorkerMenu());
                else Change_Window(new UserMenu());
            }
            else MessageBox.Show("Nieprawidłowe dane logowania.");            
        }
    }
}
