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
    public partial class SeanceView : AbstractChangingWindow,Interfaces.ISeance
    {
        private SeanceViewModel viewModel;
        public SeanceView()
        {
            InitializeComponent();
            viewModel = new SeanceViewModel(this);
            comboBoxHall.Text = GetHall();
            comboBoxMovie.Text = GetMovie();
            comboBoxHall.Items.AddRange(GetHallsArray());
            comboBoxMovie.Items.AddRange(GetMoviesArray());
            dateTimePicker.Value = GetDate();
        }

        public Func<string[]> GetHallsArray { get; set; }
        public Func<string[]> GetMoviesArray { get; set; }
        public Func<string> GetHall { get; set; }
        public Func<string> GetMovie { get; set; }
        public Func<DateTime> GetDate { get; set; }
        public Action<string> SetHall { get; set; }
        public Action<string> SetMovie { get; set; }
        public Action<DateTime> SetDate { get; set; }
        public Action SaveSeance { get; set; }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var hall = comboBoxHall.Text;
            var movie = comboBoxMovie.Text;
            var date = dateTimePicker.Value;
            SetHall(hall);
            SetMovie(movie);
            SetDate(date);
            SaveSeance();
        }
    }
}
