using System;
using System.Windows.Forms;
using Kino.Validators;

namespace Kino.Views
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            //ChangeWindow(new ReserveView());

            var test = HallValidator.HallAddValidation("test hall");
            Console.WriteLine(test);
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