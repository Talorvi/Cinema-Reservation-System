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
    public partial class SeancesList : AbstractChangingWindow , Interfaces.ISeancesWorkerList
    {
        private int index = -1;
        public Action LoadSenacesList { get; set; }
        public Func<int> GetSeancesListCount { get; set; }
        public Action<int> ReadSeanceOnIndex { get; set; }
        public Func<string> GetSeanceTitle { get; set; }
        public Func<DateTime> GetSeanceDate { get; set; }
        public Func<string> GetHallName { get; set; }
        public Action<int> RemoveSeanceOnIndex { get; set; }
        public Action<int> EditSeanceOnIndex { get; set; }
        public Action MakeNewSeanceObject { get; set; }

        public SeancesList()
        {
            InitializeComponent();
            listViewSeances.Items.Clear();
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            LoadSenacesList();
            var count = GetSeancesListCount();
            for (var i = 0; i < count; i++)
            {
                ReadSeanceOnIndex(i);
                var obj = new ListViewItem(GetSeanceTitle());
                obj.SubItems.Add(GetSeanceDate().ToString());
                obj.SubItems.Add(GetHallName());
                listViewSeances.Items.Add(obj);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MakeNewSeanceObject();
            var win = new SeanceView();
            var vm = new SeanceViewModel(win);
            Change_Window(win);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditSeanceOnIndex(index);
            var win = new SeanceView();
            var vm = new SeanceViewModel(win);
            Change_Window(win);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            RemoveSeanceOnIndex(index);
            listViewSeances.Items.RemoveAt(index);
        }

        private void listViewSeancess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSeances.SelectedIndices.Count > 0)
            {
                index = listViewSeances.SelectedIndices[0];
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
