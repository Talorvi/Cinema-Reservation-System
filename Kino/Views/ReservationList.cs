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
    public partial class ReservationList : AbstractChangingWindow, Interfaces.IReservationsWorkerList
    {
        public ReservationList()
        {
            InitializeComponent();
            listViewReservations.Items.Clear();
            LoadReservationsList();
            var count = GetReservationListCount();
            for (var i = 0; i < count; i++)
            {
                ReadReservationOnIndex(i);
                var obj = new ListViewItem(GetReservationUser());
                obj.SubItems.Add(GetMovieTitle());
                obj.SubItems.Add(GetSeatNumber().ToString());
                obj.SubItems.Add(GetHallName());
                obj.SubItems.Add(GetDate().ToString());
                obj.SubItems.Add(GetConfirmation().ToString());
                listViewReservations.Items.Add(obj);
            }

        }

        public Action LoadReservationsList { get; set; }
        public Func<int> GetReservationListCount { get; set; }
        public Action<int> ReadReservationOnIndex { get; set; }
        public Func<string> GetReservationUser { get; set; }
        public Func<string> GetMovieTitle { get; set; }
        public Func<string> GetHallName { get; set; }
        public Func<int> GetSeatNumber { get; set; }
        public Func<DateTime> GetDate { get; set; }
        public Func<bool> GetConfirmation { get; set; }
    }
}
