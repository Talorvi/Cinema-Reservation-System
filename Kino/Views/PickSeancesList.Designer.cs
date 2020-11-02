namespace Kino.Views
{
    partial class PickSeancesList
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
            this.listViewSeances = new System.Windows.Forms.ListView();
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonReserve = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewSeances
            // 
            this.listViewSeances.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSeances.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle,
            this.columnHeaderDate});
            this.listViewSeances.FullRowSelect = true;
            this.listViewSeances.HideSelection = false;
            this.listViewSeances.Location = new System.Drawing.Point(20, 72);
            this.listViewSeances.Name = "listViewSeances";
            this.listViewSeances.Size = new System.Drawing.Size(704, 400);
            this.listViewSeances.TabIndex = 0;
            this.listViewSeances.UseCompatibleStateImageBehavior = false;
            this.listViewSeances.View = System.Windows.Forms.View.Details;
            this.listViewSeances.SelectedIndexChanged += new System.EventHandler(this.listViewSeancess_SelectedIndexChanged);
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Tytuł";
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Data";
            // 
            // buttonReserve
            // 
            this.buttonReserve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReserve.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReserve.Location = new System.Drawing.Point(610, 33);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(113, 33);
            this.buttonReserve.TabIndex = 1;
            this.buttonReserve.Text = "Zarezerwuj";
            this.buttonReserve.UseVisualStyleBackColor = true;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(16, 35);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(88, 23);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Seanse";
            // 
            // PickSeancesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonReserve);
            this.Controls.Add(this.listViewSeances);
            this.Name = "PickSeancesList";
            this.Size = new System.Drawing.Size(748, 491);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSeances;
        private System.Windows.Forms.Button buttonReserve;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
    }
}
