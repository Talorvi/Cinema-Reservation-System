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
    public partial class UserMenu : AbstractChangingWindow , Interfaces.ILoggedWindow
    {
        private MenuViewModel viewModel;
        public UserMenu()
        {
            InitializeComponent();
            viewModel = new MenuViewModel(this);
        }

        public Action Logout { get; set; }
        private void Change_Panel(AbstractChangingWindow window)
        {
            splitContainerUserMenu.Panel2.Controls.Clear();
            window.Change_Window += Change_Panel;
            window.Dock = DockStyle.Fill;
            splitContainerUserMenu.Panel2.Controls.Add(window);
        }

        private void buttonReservations_Click(object sender, EventArgs e)
        {
            Change_Panel(new MyReservationList());
        }

        private void buttonSeances_Click(object sender, EventArgs e)
        {
            Change_Panel(new PickSeancesList());
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            Change_Panel(new AccountView());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Logout();
            Change_Window(new LoginView());
        }
    }
}
