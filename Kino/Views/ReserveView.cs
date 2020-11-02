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
    public partial class ReserveView : AbstractChangingWindow, Interfaces.INewReservation
    {
        public ReserveView()
        {
            InitializeComponent();
            labelTitle.Text = GetMovieTitle();
            labelDate.Text = GetDate().ToString("MM/dd/yyyy HH:mm");
            var locked = GetSeatsLocked();
            foreach(var x in locked)
            {
                Controls["radioButton" + x].Enabled = false;
            }
        }

        private int index = -1;
        public Func<string> GetMovieTitle { get; set; }
        public Func<string> GetHallName { get; set; }
        public Func<DateTime> GetDate { get; set; }
        public Func<int[]> GetSeatsLocked { get; set; }
        public Action<int[]> ReserveSeats { get; set; }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                ReserveSeats(new int[] { index });
                var win = new PickSeancesList();
                var vm = new PickSeanceViewModel(win);
                Change_Window(win);
            }
            else MessageBox.Show("Nie wybrano miejsca.");
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton)
            {
                if((sender as RadioButton).Checked == true)
                {
                    index = int.Parse((sender as RadioButton).Name.Trim().Last().ToString());
                }
            }
        }
    }
}
