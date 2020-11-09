namespace Kino.Views
{
    partial class ReserveView
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPickSeat = new System.Windows.Forms.Label();
            this.tableLayoutPanelSeats = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.tableLayoutPanelSeats.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(25, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(197, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nowa rezerwacja";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(26, 54);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(23, 16);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "...";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDate.Location = new System.Drawing.Point(26, 81);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(23, 16);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "...";
            // 
            // labelPickSeat
            // 
            this.labelPickSeat.AutoSize = true;
            this.labelPickSeat.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPickSeat.Location = new System.Drawing.Point(26, 111);
            this.labelPickSeat.Name = "labelPickSeat";
            this.labelPickSeat.Size = new System.Drawing.Size(148, 18);
            this.labelPickSeat.TabIndex = 3;
            this.labelPickSeat.Text = "Wybierz miejsce:";
            // 
            // tableLayoutPanelSeats
            // 
            this.tableLayoutPanelSeats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelSeats.ColumnCount = 4;
            this.tableLayoutPanelSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSeats.Controls.Add(this.radioButton16, 3, 3);
            this.tableLayoutPanelSeats.Controls.Add(this.radioButton15, 2, 3);
            this.tableLayoutPanelSeats.Controls.Add(this.radioButton14, 1, 3);
            this.tableLayoutPanelSeats.Controls.Add(this.radioButton13, 0, 3);
            this.tableLayoutPanelSeats.Controls.Add(this.radioButton12, 3, 2);
            this.tableLayoutPanelSeats.Controls.Add(this.radioButton11, 2, 2);
            this.tableLayoutPanelSeats.Controls.Add(this.radioButton10, 1, 2);
            this.tableLayoutPanelSeats.Controls.Add(this.radioButton9, 0, 2);
            this.tableLayoutPanelSeats.Controls.Add(this.radioButton8, 3, 1);
            this.tableLayoutPanelSeats.Controls.Add(this.radioButton7, 2, 1);
            this.tableLayoutPanelSeats.Controls.Add(this.radioButton6, 1, 1);
            this.tableLayoutPanelSeats.Controls.Add(this.radioButton5, 0, 1);
            this.tableLayoutPanelSeats.Controls.Add(this.radioButton4, 3, 0);
            this.tableLayoutPanelSeats.Controls.Add(this.radioButton3, 2, 0);
            this.tableLayoutPanelSeats.Controls.Add(this.radioButton2, 1, 0);
            this.tableLayoutPanelSeats.Controls.Add(this.radioButton1, 0, 0);
            this.tableLayoutPanelSeats.Location = new System.Drawing.Point(29, 142);
            this.tableLayoutPanelSeats.Name = "tableLayoutPanelSeats";
            this.tableLayoutPanelSeats.RowCount = 4;
            this.tableLayoutPanelSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSeats.Size = new System.Drawing.Size(803, 426);
            this.tableLayoutPanelSeats.TabIndex = 4;
            // 
            // radioButton16
            // 
            this.radioButton16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton16.AutoSize = true;
            this.radioButton16.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton16.Enabled = false;
            this.radioButton16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton16.Location = new System.Drawing.Point(686, 355);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(30, 33);
            this.radioButton16.TabIndex = 15;
            this.radioButton16.TabStop = true;
            this.radioButton16.Text = "16";
            this.radioButton16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton16.UseVisualStyleBackColor = true;
            this.radioButton16.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton15
            // 
            this.radioButton15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton15.AutoSize = true;
            this.radioButton15.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton15.Enabled = false;
            this.radioButton15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton15.Location = new System.Drawing.Point(485, 355);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(30, 33);
            this.radioButton15.TabIndex = 14;
            this.radioButton15.TabStop = true;
            this.radioButton15.Text = "15";
            this.radioButton15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton15.UseVisualStyleBackColor = true;
            this.radioButton15.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton14
            // 
            this.radioButton14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton14.AutoSize = true;
            this.radioButton14.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton14.Enabled = false;
            this.radioButton14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton14.Location = new System.Drawing.Point(285, 355);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(30, 33);
            this.radioButton14.TabIndex = 13;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "14";
            this.radioButton14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton14.UseVisualStyleBackColor = true;
            this.radioButton14.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton13
            // 
            this.radioButton13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton13.AutoSize = true;
            this.radioButton13.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton13.Enabled = false;
            this.radioButton13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton13.Location = new System.Drawing.Point(85, 355);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(30, 33);
            this.radioButton13.TabIndex = 12;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "13";
            this.radioButton13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton13.UseVisualStyleBackColor = true;
            this.radioButton13.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton12
            // 
            this.radioButton12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton12.AutoSize = true;
            this.radioButton12.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton12.Enabled = false;
            this.radioButton12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton12.Location = new System.Drawing.Point(686, 248);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(30, 33);
            this.radioButton12.TabIndex = 11;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "12";
            this.radioButton12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton11
            // 
            this.radioButton11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton11.AutoSize = true;
            this.radioButton11.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton11.Enabled = false;
            this.radioButton11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton11.Location = new System.Drawing.Point(485, 248);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(30, 33);
            this.radioButton11.TabIndex = 10;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "11";
            this.radioButton11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton10.AutoSize = true;
            this.radioButton10.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton10.Enabled = false;
            this.radioButton10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton10.Location = new System.Drawing.Point(285, 248);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(30, 33);
            this.radioButton10.TabIndex = 9;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "10";
            this.radioButton10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton9.AutoSize = true;
            this.radioButton9.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton9.Enabled = false;
            this.radioButton9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton9.Location = new System.Drawing.Point(89, 248);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(21, 33);
            this.radioButton9.TabIndex = 8;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "9";
            this.radioButton9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton8.AutoSize = true;
            this.radioButton8.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton8.Enabled = false;
            this.radioButton8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton8.Location = new System.Drawing.Point(691, 142);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(21, 33);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "8";
            this.radioButton8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton7.AutoSize = true;
            this.radioButton7.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton7.Enabled = false;
            this.radioButton7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton7.Location = new System.Drawing.Point(489, 142);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(21, 33);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "7";
            this.radioButton7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton6.AutoSize = true;
            this.radioButton6.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton6.Enabled = false;
            this.radioButton6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton6.Location = new System.Drawing.Point(289, 142);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(21, 33);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "6";
            this.radioButton6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton5.AutoSize = true;
            this.radioButton5.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton5.Enabled = false;
            this.radioButton5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton5.Location = new System.Drawing.Point(89, 142);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(21, 33);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5";
            this.radioButton5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton4.AutoSize = true;
            this.radioButton4.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton4.Enabled = false;
            this.radioButton4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton4.Location = new System.Drawing.Point(691, 36);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(21, 33);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton3.AutoSize = true;
            this.radioButton3.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton3.Enabled = false;
            this.radioButton3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton3.Location = new System.Drawing.Point(489, 36);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(21, 33);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton2.AutoSize = true;
            this.radioButton2.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton2.Enabled = false;
            this.radioButton2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton2.Location = new System.Drawing.Point(289, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(21, 33);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1.AutoSize = true;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton1.Enabled = false;
            this.radioButton1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton1.Location = new System.Drawing.Point(89, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(21, 33);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // buttonReserve
            // 
            this.buttonReserve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReserve.Enabled = false;
            this.buttonReserve.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReserve.Location = new System.Drawing.Point(741, 105);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(91, 31);
            this.buttonReserve.TabIndex = 5;
            this.buttonReserve.Text = "Rezerwuj";
            this.buttonReserve.UseVisualStyleBackColor = true;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click);
            // 
            // ReserveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonReserve);
            this.Controls.Add(this.tableLayoutPanelSeats);
            this.Controls.Add(this.labelPickSeat);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelName);
            this.Name = "ReserveView";
            this.Size = new System.Drawing.Size(863, 591);
            this.tableLayoutPanelSeats.ResumeLayout(false);
            this.tableLayoutPanelSeats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPickSeat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSeats;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button buttonReserve;
    }
}
