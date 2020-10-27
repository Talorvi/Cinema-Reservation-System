using System.Windows.Forms;

namespace Kino.Views
{
    public partial class LoginView : AbstractChangingWindow
    {

        public LoginView()
        {
            InitializeComponent();
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Change_Window(new RegisterView());
        }
    }
}
