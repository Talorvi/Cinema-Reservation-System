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
        public WorkerMenu()
        {
            InitializeComponent();
        }

        public Action Logout { get; set; }

        private void buttonMovies_Click(object sender, EventArgs e)
        {
            var win = new MovieList();
            var vm = new MoviesViewModel(win);
            Change_Panel(win);
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
            var win = new HallsList();
            var vm = new HallsViewModel(win);
            Change_Panel(win);
        }

        private void buttonSeances_Click(object sender, EventArgs e)
        {
            Change_Panel(new SeancesList());
        }

        private void buttonReservations_Click(object sender, EventArgs e)
        {
            var win = new ReservationList();
            var vn = new ReservationsViewModel(win);
            Change_Panel(win);
        }

        private void buttonWorkers_Click(object sender, EventArgs e)
        {
            var win = new WorkerList();
            var vm = new WorkerListViewModel(win);
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
