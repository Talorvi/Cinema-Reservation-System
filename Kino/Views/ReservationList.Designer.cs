namespace Kino.Views
{
    partial class ReservationList
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
            this.listViewReservations = new System.Windows.Forms.ListView();
            this.columnHeaderUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMovie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSeat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHall = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderConfirmed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewReservations
            // 
            this.listViewReservations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewReservations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderUser,
            this.columnHeaderMovie,
            this.columnHeaderSeat,
            this.columnHeaderHall,
            this.columnHeaderDate,
            this.columnHeaderConfirmed});
            this.listViewReservations.FullRowSelect = true;
            this.listViewReservations.HideSelection = false;
            this.listViewReservations.Location = new System.Drawing.Point(26, 96);
            this.listViewReservations.Name = "listViewReservations";
            this.listViewReservations.Size = new System.Drawing.Size(853, 461);
            this.listViewReservations.TabIndex = 0;
            this.listViewReservations.UseCompatibleStateImageBehavior = false;
            this.listViewReservations.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderUser
            // 
            this.columnHeaderUser.Text = "Użytkownik";
            this.columnHeaderUser.Width = 100;
            // 
            // columnHeaderMovie
            // 
            this.columnHeaderMovie.Text = "Film";
            // 
            // columnHeaderSeat
            // 
            this.columnHeaderSeat.Text = "Miejsce";
            // 
            // columnHeaderHall
            // 
            this.columnHeaderHall.Text = "Sala";
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Data";
            this.columnHeaderDate.Width = 104;
            // 
            // columnHeaderConfirmed
            // 
            this.columnHeaderConfirmed.Text = "Potwierdzona";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(23, 58);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(135, 23);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Rezerwacje";
            // 
            // ReservationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.listViewReservations);
            this.Name = "ReservationList";
            this.Size = new System.Drawing.Size(906, 581);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewReservations;
        private System.Windows.Forms.ColumnHeader columnHeaderUser;
        private System.Windows.Forms.ColumnHeader columnHeaderMovie;
        private System.Windows.Forms.ColumnHeader columnHeaderSeat;
        private System.Windows.Forms.ColumnHeader columnHeaderHall;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderConfirmed;
        private System.Windows.Forms.Label labelTitle;
    }
}
