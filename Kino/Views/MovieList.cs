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
    public partial class MovieList : AbstractChangingWindow, Interfaces.IMoviesWorkerList
    {
        public MovieList()
        {
            InitializeComponent();
            listViewMovies.Items.Clear();
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            LoadMoviesList();
            var count = GetMoviesListCount();
            for(var i = 0; i < count; i++)
            {
                ReadMovieOnIndex(i);
                var obj = new ListViewItem(GetMovieTitle());
                listViewMovies.Items.Add(obj);
            }
        }

        private int index = -1;
        public Action LoadMoviesList { get; set; }
        public Func<int> GetMoviesListCount { get; set; }
        public Action<int> ReadMovieOnIndex { get; set; }
        public Func<string> GetMovieTitle { get; set; }
        public Action<int> RemoveMovieOnIndex { get; set; }
        public Action<int> EditMovieOnIndex { get; set; }
        public Action MakeNewMovieObject { get; set; }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MakeNewMovieObject();
            Change_Window(new MovieView());
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditMovieOnIndex(index);
            Change_Window(new MovieView());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            RemoveMovieOnIndex(index);
            listViewMovies.Items.RemoveAt(index);
        }

        private void listViewMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewMovies.SelectedIndices.Count > 0)
            {
                index = listViewMovies.SelectedIndices[0];
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
