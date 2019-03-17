namespace Vtdi_Gatelog
{
    partial class LogInForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btReset = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(195, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In Here";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbUsername.Location = new System.Drawing.Point(244, 49);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(111, 28);
            this.lbUsername.TabIndex = 3;
            this.lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbPassword.Location = new System.Drawing.Point(244, 123);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(104, 28);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LightYellow;
            this.txtPassword.Location = new System.Drawing.Point(232, 154);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(138, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(232, 80);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(138, 20);
            this.txtUserName.TabIndex = 11;
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.ForestGreen;
            this.btReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btReset.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btReset.Location = new System.Drawing.Point(262, 248);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 36);
            this.btReset.TabIndex = 7;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            this.btReset.MouseHover += new System.EventHandler(this.btReset_MouseHover);
            // 
            // btSubmit
            // 
            this.btSubmit.BackColor = System.Drawing.Color.ForestGreen;
            this.btSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSubmit.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btSubmit.Location = new System.Drawing.Point(48, 248);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(88, 36);
            this.btSubmit.TabIndex = 8;
            this.btSubmit.Text = "Log In";
            this.btSubmit.UseVisualStyleBackColor = false;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            this.btSubmit.MouseHover += new System.EventHandler(this.btSubmit_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(416, 286);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btSubmit;
    }
}