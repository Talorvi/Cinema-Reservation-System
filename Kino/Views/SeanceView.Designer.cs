namespace Kino.Views
{
    partial class SeanceView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelSeance = new System.Windows.Forms.TableLayoutPanel();
            this.labelMovie = new System.Windows.Forms.Label();
            this.labelHall = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.comboBoxMovie = new System.Windows.Forms.ComboBox();
            this.comboBoxHall = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanelSeance.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelSeance
            // 
            this.tableLayoutPanelSeance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelSeance.ColumnCount = 1;
            this.tableLayoutPanelSeance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSeance.Controls.Add(this.labelMovie, 0, 1);
            this.tableLayoutPanelSeance.Controls.Add(this.labelHall, 0, 3);
            this.tableLayoutPanelSeance.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanelSeance.Controls.Add(this.labelDate, 0, 5);
            this.tableLayoutPanelSeance.Controls.Add(this.comboBoxMovie, 0, 2);
            this.tableLayoutPanelSeance.Controls.Add(this.comboBoxHall, 0, 4);
            this.tableLayoutPanelSeance.Controls.Add(this.buttonSave, 0, 7);
            this.tableLayoutPanelSeance.Controls.Add(this.dateTimePicker, 0, 6);
            this.tableLayoutPanelSeance.Location = new System.Drawing.Point(27, 191);
            this.tableLayoutPanelSeance.Name = "tableLayoutPanelSeance";
            this.tableLayoutPanelSeance.RowCount = 8;
            this.tableLayoutPanelSeance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelSeance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelSeance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelSeance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelSeance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelSeance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelSeance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelSeance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelSeance.Size = new System.Drawing.Size(839, 240);
            this.tableLayoutPanelSeance.TabIndex = 0;
            // 
            // labelMovie
            // 
            this.labelMovie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMovie.AutoSize = true;
            this.labelMovie.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMovie.Location = new System.Drawing.Point(3, 51);
            this.labelMovie.Name = "labelMovie";
            this.labelMovie.Size = new System.Drawing.Size(45, 18);
            this.labelMovie.TabIndex = 0;
            this.labelMovie.Text = "Film:";
            // 
            // labelHall
            // 
            this.labelHall.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelHall.AutoSize = true;
            this.labelHall.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHall.Location = new System.Drawing.Point(3, 101);
            this.labelHall.Name = "labelHall";
            this.labelHall.Size = new System.Drawing.Size(46, 18);
            this.labelHall.TabIndex = 1;
            this.labelHall.Text = "Sala:";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(3, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(75, 23);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Seans";
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDate.Location = new System.Drawing.Point(3, 151);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(50, 18);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Data:";
            // 
            // comboBoxMovie
            // 
            this.comboBoxMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxMovie.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxMovie.FormattingEnabled = true;
            this.comboBoxMovie.Location = new System.Drawing.Point(3, 73);
            this.comboBoxMovie.Name = "comboBoxMovie";
            this.comboBoxMovie.Size = new System.Drawing.Size(833, 24);
            this.comboBoxMovie.TabIndex = 4;
            // 
            // comboBoxHall
            // 
            this.comboBoxHall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxHall.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxHall.FormattingEnabled = true;
            this.comboBoxHall.Location = new System.Drawing.Point(3, 123);
            this.comboBoxHall.Name = "comboBoxHall";
            this.comboBoxHall.Size = new System.Drawing.Size(833, 24);
            this.comboBoxHall.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(382, 203);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 34);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "MM/dd/yyyy HH:mm";
            this.dateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(3, 173);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(833, 23);
            this.dateTimePicker.TabIndex = 8;
            // 
            // SeanceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelSeance);
            this.Name = "SeanceView";
            this.Size = new System.Drawing.Size(893, 573);
            this.tableLayoutPanelSeance.ResumeLayout(false);
            this.tableLayoutPanelSeance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSeance;
        private System.Windows.Forms.Label labelMovie;
        private System.Windows.Forms.Label labelHall;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ComboBox comboBoxMovie;
        private System.Windows.Forms.ComboBox comboBoxHall;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}
