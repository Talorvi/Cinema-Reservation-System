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
    public partial class PickSeancesList : AbstractChangingWindow, Interfaces.ISeancesList
    {
        public PickSeancesList()
        {
            InitializeComponent();
            listViewSeances.Items.Clear();
            buttonReserve.Enabled = false;
            LoadSenacesList();
            var count = GetSeancesListCount();
            for (var i = 0; i < count; i++)
            {
                ReadSeanceOnIndex(i);
                var obj = new ListViewItem(GetSeanceTitle());
                obj.SubItems.Add(GetSeanceDate().ToString());
                listViewSeances.Items.Add(obj);
            }
        }

        private int index = -1;
        public Action LoadSenacesList { get; set; }
        public Func<int> GetSeancesListCount { get; set; }
        public Action<int> ReadSeanceOnIndex { get; set; }
        public Func<string> GetSeanceTitle { get; set; }
        public Func<DateTime> GetSeanceDate { get; set; }
        public Action<int> MakeSeanceReservationOnIndex { get; set; }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            MakeSeanceReservationOnIndex(index);
            var win = new ReserveView();
            var vm = new ReserveViewModel(win);
            Change_Window(win);
        }

        private void listViewSeancess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSeances.SelectedIndices.Count > 0)
            {
                index = listViewSeances.SelectedIndices[0];
                buttonReserve.Enabled = true;
            }
            else
            {
                index = -1;
                buttonReserve.Enabled = false;
            }
        }
    }
}
