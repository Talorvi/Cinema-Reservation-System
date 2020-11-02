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
    public partial class MovieView : AbstractChangingWindow, Interfaces.IMovie
    {
        public MovieView()
        {
            InitializeComponent();
            textBoxName.Text = GetMovieTitle();
        }

        public Action<string> SetMovieTitle { get; set; }
        public Action SaveMovie { get; set; }
        public Func<string> GetMovieTitle { get; set; }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text;
            if (name != "")
            {
                SetMovieTitle(name);
                SaveMovie();
            }
            else MessageBox.Show("Nazwa nie może być pusta.");
        }
    }
}
