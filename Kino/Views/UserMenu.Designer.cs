namespace Kino.Views
{
    partial class UserMenu
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
            this.splitContainerUserMenu = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelUserMenu = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonReservations = new System.Windows.Forms.Button();
            this.buttonSeances = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUserMenu)).BeginInit();
            this.splitContainerUserMenu.Panel1.SuspendLayout();
            this.splitContainerUserMenu.SuspendLayout();
            this.tableLayoutPanelUserMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerUserMenu
            // 
            this.splitContainerUserMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerUserMenu.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerUserMenu.IsSplitterFixed = true;
            this.splitContainerUserMenu.Location = new System.Drawing.Point(0, 0);
            this.splitContainerUserMenu.Name = "splitContainerUserMenu";
            // 
            // splitContainerUserMenu.Panel1
            // 
            this.splitContainerUserMenu.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainerUserMenu.Panel1.Controls.Add(this.tableLayoutPanelUserMenu);
            this.splitContainerUserMenu.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainerUserMenu.Panel1MinSize = 215;
            // 
            // splitContainerUserMenu.Panel2
            // 
            this.splitContainerUserMenu.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainerUserMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainerUserMenu.Size = new System.Drawing.Size(904, 596);
            this.splitContainerUserMenu.SplitterDistance = 215;
            this.splitContainerUserMenu.SplitterWidth = 1;
            this.splitContainerUserMenu.TabIndex = 1;
            // 
            // tableLayoutPanelUserMenu
            // 
            this.tableLayoutPanelUserMenu.ColumnCount = 1;
            this.tableLayoutPanelUserMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUserMenu.Controls.Add(this.buttonAccount, 0, 3);
            this.tableLayoutPanelUserMenu.Controls.Add(this.buttonReservations, 0, 1);
            this.tableLayoutPanelUserMenu.Controls.Add(this.buttonSeances, 0, 2);
            this.tableLayoutPanelUserMenu.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanelUserMenu.Controls.Add(this.buttonLogout, 0, 4);
            this.tableLayoutPanelUserMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelUserMenu.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelUserMenu.Name = "tableLayoutPanelUserMenu";
            this.tableLayoutPanelUserMenu.RowCount = 5;
            this.tableLayoutPanelUserMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelUserMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUserMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUserMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUserMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUserMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUserMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUserMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUserMenu.Size = new System.Drawing.Size(215, 220);
            this.tableLayoutPanelUserMenu.TabIndex = 0;
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackColor = System.Drawing.Color.Transparent;
            this.buttonAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAccount.FlatAppearance.BorderSize = 0;
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccount.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAccount.Location = new System.Drawing.Point(0, 160);
            this.buttonAccount.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(215, 30);
            this.buttonAccount.TabIndex = 13;
            this.buttonAccount.Text = "Moje konto";
            this.buttonAccount.UseVisualStyleBackColor = false;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
            // 
            // buttonReservations
            // 
            this.buttonReservations.BackColor = System.Drawing.Color.Transparent;
            this.buttonReservations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReservations.FlatAppearance.BorderSize = 0;
            this.buttonReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReservations.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReservations.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonReservations.Location = new System.Drawing.Point(0, 100);
            this.buttonReservations.Margin = new System.Windows.Forms.Padding(0);
            this.buttonReservations.Name = "buttonReservations";
            this.buttonReservations.Size = new System.Drawing.Size(215, 30);
            this.buttonReservations.TabIndex = 11;
            this.buttonReservations.Text = "Rezerwacje";
            this.buttonReservations.UseVisualStyleBackColor = false;
            this.buttonReservations.Click += new System.EventHandler(this.buttonReservations_Click);
            // 
            // buttonSeances
            // 
            this.buttonSeances.BackColor = System.Drawing.Color.Transparent;
            this.buttonSeances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSeances.FlatAppearance.BorderSize = 0;
            this.buttonSeances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeances.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSeances.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSeances.Location = new System.Drawing.Point(0, 130);
            this.buttonSeances.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSeances.Name = "buttonSeances";
            this.buttonSeances.Size = new System.Drawing.Size(215, 30);
            this.buttonSeances.TabIndex = 10;
            this.buttonSeances.Text = "Seanse";
            this.buttonSeances.UseVisualStyleBackColor = false;
            this.buttonSeances.Click += new System.EventHandler(this.buttonSeances_Click);
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(37, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(140, 35);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Ræserve";
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLogout.Location = new System.Drawing.Point(0, 190);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(215, 30);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "Wyloguj się";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerUserMenu);
            this.Name = "UserMenu";
            this.Size = new System.Drawing.Size(904, 596);
            this.splitContainerUserMenu.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUserMenu)).EndInit();
            this.splitContainerUserMenu.ResumeLayout(false);
            this.tableLayoutPanelUserMenu.ResumeLayout(false);
            this.tableLayoutPanelUserMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerUserMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUserMenu;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Button buttonReservations;
        private System.Windows.Forms.Button buttonSeances;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonLogout;
    }
}
