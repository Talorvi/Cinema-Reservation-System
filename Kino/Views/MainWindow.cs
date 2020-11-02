using Kino.ViewModels;
using System.Windows.Forms;

namespace Kino.Views
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            var window = new LoginView();
            var vm = new LoginViewModel(window);
            ChangeWindow(window);

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