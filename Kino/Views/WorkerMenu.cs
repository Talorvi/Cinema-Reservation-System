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
    public partial class WorkerMenu : AbstractChangingWindow , Interfaces.ILoggedWindow
    {
        private MenuViewModel viewModel;
        public WorkerMenu()
        {
            InitializeComponent();
            viewModel = new MenuViewModel(this);
        }

        public Action Logout { get; set; }

        private void buttonMovies_Click(object sender, EventArgs e)
        {
            Change_Panel(new MovieList());
        }

        private void Change_Panel(AbstractChangingWindow window)
        {
            splitContainerWorkerMenu.Panel2.Controls.Clear();
            window.Change_Window += Change_Panel;
            window.Dock = DockStyle.Fill;
            splitContainerWorkerMenu.Panel2.Controls.Add(window);
        }

        private void buttonHalls_Click(object sender, EventArgs e)
        {
            Change_Panel(new HallsList());
        }

        private void buttonSeances_Click(object sender, EventArgs e)
        {
            Change_Panel(new SeancesList());
        }

        private void buttonReservations_Click(object sender, EventArgs e)
        {
            Change_Panel(new ReservationList());
        }

        private void buttonWorkers_Click(object sender, EventArgs e)
        {
            Change_Panel(new WorkerList());
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
