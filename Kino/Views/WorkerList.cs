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
    public partial class WorkerList : AbstractChangingWindow, Interfaces.IWorkersList
    {
        private int index = -1;
        public Action LoadWorkersList { get; set; }
        public Func<int> GetWorkersListCount { get; set; }
        public Action<int> ReadWorkerOnIndex { get; set; }
        public Func<string> GetWorkerUsername { get; set; }
        public Action<int> RemoveWorkerOnIndex { get; set; }
        public Action<int> EditWorkerOnIndex { get; set; }
        public Action MakeNewWorker { get; set; }

        public WorkerList()
        {
            InitializeComponent();
            listViewWorkers.Items.Clear();
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            LoadWorkersList();
            var count = GetWorkersListCount();
            for (var i = 0; i < count; i++)
            {
                ReadWorkerOnIndex(i);
                var obj = new ListViewItem(GetWorkerUsername());
                listViewWorkers.Items.Add(obj);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MakeNewWorker();
            Change_Window(new WorkerView());
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditWorkerOnIndex(index);
            Change_Window(new WorkerView());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            RemoveWorkerOnIndex(index);
            listViewWorkers.Items.RemoveAt(index);
        }

        private void listViewWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewWorkers.SelectedIndices.Count > 0)
            {
                index = listViewWorkers.SelectedIndices[0];
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
