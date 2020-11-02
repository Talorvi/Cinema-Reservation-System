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
    public partial class WorkerView : AbstractChangingWindow, Interfaces.IWorker
    {
        public WorkerView()
        {
            InitializeComponent();
            textBoxName.Text = GetWorkerUsername();
        }

        public Func<string> GetWorkerUsername { get; set; }
        public Action<string> SetWorkerUsername { get; set; }
        public Action SaveWorker { get; set; }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text;
            if (name != "")
            {
                SetWorkerUsername(name);
                SaveWorker();
            }
            else MessageBox.Show("Nazwa nie może być pusta.");
        }
    }
}
