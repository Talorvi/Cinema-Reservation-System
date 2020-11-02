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
        public UserMenu()
        {
            InitializeComponent();
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
            var win = new MyReservationList();
            var vm = new MyReservationViewModel(win);
            Change_Panel(win);
        }

        private void buttonSeances_Click(object sender, EventArgs e)
        {
            var win = new PickSeancesList();
            var vm = new PickSeanceViewModel(win);
            Change_Panel(win);
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            var win = new AccountView();
            var vm = new AccountViewModel(win);
            Change_Panel(win);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Logout();
            var window = new LoginView();
            var vm = new LoginViewModel(window);
            Change_Window(window);
        }
    }
}
