using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino.Views
{
    public partial class MyReservationList : AbstractChangingWindow, Interfaces.IMyReservationsList
    {
        public MyReservationList()
        {
            InitializeComponent();
            listViewMyReservations.Items.Clear();
            buttonConfirm.Enabled = false;
            LoadReservationsList();
            var count = GetReservationListCount();
            for (var i = 0; i < count; i++)
            {
                ReadReservationOnIndex(i);
                var obj = new ListViewItem(GetMovieTitle());
                obj.SubItems.Add(GetSeatNumber().ToString());
                obj.SubItems.Add(GetHallName());
                obj.SubItems.Add(GetDate().ToString());
                obj.SubItems.Add(GetConfirmation().ToString());
                listViewMyReservations.Items.Add(obj);
            }
        }

        private int index = -1;
        public Action LoadReservationsList { get; set; }
        public Func<int> GetReservationListCount { get; set; }
        public Action<int> ReadReservationOnIndex { get; set; }
        public Func<string> GetMovieTitle { get; set; }
        public Func<string> GetHallName { get; set; }
        public Func<int> GetSeatNumber { get; set; }
        public Func<DateTime> GetDate { get; set; }
        public Func<bool> GetConfirmation { get; set; }
        public Action<int> ConfirmReservationAtIndex { get; set; }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            ConfirmReservationAtIndex(index);
            listViewMyReservations.Items[index].SubItems[3].Text = "True";
        }

        private void listViewMyReservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMyReservations.SelectedIndices.Count > 0)
            {
                index = listViewMyReservations.SelectedIndices[0];
                if(listViewMyReservations.Items[index].SubItems[3].Text == "False")
                    buttonConfirm.Enabled = true;
            }
            else
            {
                index = -1;
                buttonConfirm.Enabled = false;
            }

        }
    }
}
