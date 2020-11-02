namespace Kino.Views
{
    partial class AccountView
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
            this.tableLayoutPanelAccount = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelOldPassword = new System.Windows.Forms.Label();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelAccount
            // 
            this.tableLayoutPanelAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelAccount.ColumnCount = 1;
            this.tableLayoutPanelAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAccount.Controls.Add(this.textBoxConfirmPassword, 0, 6);
            this.tableLayoutPanelAccount.Controls.Add(this.textBoxNewPassword, 0, 4);
            this.tableLayoutPanelAccount.Controls.Add(this.labelNewPassword, 0, 3);
            this.tableLayoutPanelAccount.Controls.Add(this.buttonSave, 0, 7);
            this.tableLayoutPanelAccount.Controls.Add(this.labelTitle, 0, 0);
            this.tableLayoutPanelAccount.Controls.Add(this.labelOldPassword, 0, 1);
            this.tableLayoutPanelAccount.Controls.Add(this.labelConfirmPassword, 0, 5);
            this.tableLayoutPanelAccount.Controls.Add(this.textBoxOldPassword, 0, 2);
            this.tableLayoutPanelAccount.Location = new System.Drawing.Point(292, 169);
            this.tableLayoutPanelAccount.Name = "tableLayoutPanelAccount";
            this.tableLayoutPanelAccount.RowCount = 8;
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelAccount.Size = new System.Drawing.Size(200, 240);
            this.tableLayoutPanelAccount.TabIndex = 0;
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(3, 173);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.PasswordChar = '*';
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(194, 23);
            this.textBoxConfirmPassword.TabIndex = 7;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNewPassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNewPassword.Location = new System.Drawing.Point(3, 123);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(194, 23);
            this.textBoxNewPassword.TabIndex = 6;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNewPassword.Location = new System.Drawing.Point(3, 101);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(102, 18);
            this.labelNewPassword.TabIndex = 4;
            this.labelNewPassword.Text = "Nowe hasło:";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(62, 204);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 32);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(3, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(131, 23);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Moje konto";
            // 
            // labelOldPassword
            // 
            this.labelOldPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelOldPassword.AutoSize = true;
            this.labelOldPassword.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOldPassword.Location = new System.Drawing.Point(3, 51);
            this.labelOldPassword.Name = "labelOldPassword";
            this.labelOldPassword.Size = new System.Drawing.Size(99, 18);
            this.labelOldPassword.TabIndex = 2;
            this.labelOldPassword.Text = "Stare hasło:";
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelConfirmPassword.Location = new System.Drawing.Point(3, 151);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(133, 18);
            this.labelConfirmPassword.TabIndex = 3;
            this.labelConfirmPassword.Text = "Potwierdź hasło:";
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOldPassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOldPassword.Location = new System.Drawing.Point(3, 73);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.PasswordChar = '*';
            this.textBoxOldPassword.Size = new System.Drawing.Size(194, 23);
            this.textBoxOldPassword.TabIndex = 5;
            // 
            // AccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelAccount);
            this.Name = "AccountView";
            this.Size = new System.Drawing.Size(785, 579);
            this.tableLayoutPanelAccount.ResumeLayout(false);
            this.tableLayoutPanelAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAccount;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelOldPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxOldPassword;
    }
}
