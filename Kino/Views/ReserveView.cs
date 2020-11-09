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
using Kino.Utilities;
using System.Runtime.CompilerServices;

namespace Kino.Views
{
    public partial class ReserveView : AbstractChangingWindow, Interfaces.INewReservation
    {
        private ReserveViewModel viewModel;
        public ReserveView()
        {
            InitializeComponent();
            viewModel = new ReserveViewModel(this);
            labelTitle.Text = GetMovieTitle();
            labelDate.Text = GetDate().ToString("MM/dd/yyyy HH:mm");
        }
        ~ReserveView()
        {
            Cache.WsClient.Unsubscribe();
        }

        private int index = -1;
        public Func<string> GetMovieTitle { get; set; }
        public Func<string> GetHallName { get; set; }
        public Func<DateTime> GetDate { get; set; }
        public Func<int[]> GetSeatsLocked { get; set; }
        public Action<int[]> ReserveSeats { get; set; }
        private delegate void UnlockDelegate();
        private void UnlockFunction()
        {
            buttonReserve.Enabled = true;
            var locked = GetSeatsLocked();
            var unlocked = Enumerable.Range(1, 16).Except(locked);
            foreach (var x in unlocked)
            {
                Controls["tableLayoutPanelSeats"].Controls[$"radioButton{x}"].Enabled = true;
            }
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                ReserveSeats(new int[] { index });
                Change_Window(new PickSeancesList());
            }
            else MessageBox.Show("Nie wybrano miejsca.");
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                if ((sender as RadioButton).Checked == true)
                {
                    index = int.Parse((sender as RadioButton).Name.Trim().Substring(11));
                }
            }
        }
        public void Unlock()
        {
            this.Invoke(new UnlockDelegate(this.UnlockFunction));
        }
        
    }
}
