using Kino.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Kino.Views
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            ChangeWindow(new LoginView());
        }

        private void ChangeWindow(AbstractChangingWindow window) 
        {
            this.Controls.Clear();
            window.Change_Window += ChangeWindow;
            window.Dock = DockStyle.Fill;
            this.Controls.Add(window);
        }
    }
}