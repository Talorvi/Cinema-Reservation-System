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
    public partial class HallsList : AbstractChangingWindow, Interfaces.IHallWorkerList
    {
        private int index = -1;
        public Action LoadHallsList { get; set; }
        public Func<int> GetHallsListCount { get; set; }
        public Action<int> ReadHallOnIndex { get; set; }
        public Func<string> GetHallName { get; set; }
        public Action<int> RemoveHallOnIndex { get; set; }
        public Action<int> EditHallOnIndex { get; set; }
        public Action MakeNewHallObject { get; set; }

        public HallsList()
        {
            InitializeComponent();
            listViewHalls.Items.Clear();
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            LoadHallsList();
            var count = GetHallsListCount();
            for (var i = 0; i < count; i++)
            {
                ReadHallOnIndex(i);
                var obj = new ListViewItem(GetHallName());
                listViewHalls.Items.Add(obj);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MakeNewHallObject();
            Change_Window(new HallView());
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditHallOnIndex(index);
            Change_Window(new HallView());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            RemoveHallOnIndex(index);
            listViewHalls.Items.RemoveAt(index);
        }

        private void listViewHallss_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHalls.SelectedIndices.Count > 0)
            {
                index = listViewHalls.SelectedIndices[0];
                buttonEdit.Enabled = true;
                buttonDelete.Enabled = true;
            }
            else
            {
                index = -1;
                buttonEdit.Enabled = false;
                buttonDelete.Enabled = false;
            }
        }
    }
}
