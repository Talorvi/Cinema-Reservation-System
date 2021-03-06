﻿using System;
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
    public partial class HallView : AbstractChangingWindow, Interfaces.IHall
    {
        private HallViewModel viewModel;
        public HallView()
        {
            InitializeComponent();
            viewModel = new HallViewModel(this);
            textBoxName.Text = GetHallName();
        }

        public Action<string> SetHallName { get; set; }
        public Action SaveHall { get; set; }
        public Func<string> GetHallName { get; set; }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text;
            if (name != "")
            {
                SetHallName(name);
                SaveHall();
            }
            else MessageBox.Show("Nazwa nie może być pusta.");
        }
    }
}
