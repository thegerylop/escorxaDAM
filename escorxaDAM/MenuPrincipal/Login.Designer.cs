namespace MenuPrincipal
{
    partial class Login
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
            if(disposing && (components != null))
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.CCLogin = new CustomControl.CustomTextBox();
            this.CCPassword = new CustomControl.CustomTextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(246, 259);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 26);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // CCLogin
            // 
            this.CCLogin.Location = new System.Drawing.Point(186, 166);
            this.CCLogin.Name = "CCLogin";
            this.CCLogin.Options = CustomControl.CustomTextBox.Items.Text;
            this.CCLogin.Placeholder = "Usuari";
            this.CCLogin.Size = new System.Drawing.Size(191, 20);
            this.CCLogin.TabIndex = 1;
            // 
            // CCPassword
            // 
            this.CCPassword.Location = new System.Drawing.Point(186, 207);
            this.CCPassword.Name = "CCPassword";
            this.CCPassword.Options = CustomControl.CustomTextBox.Items.Password;
            this.CCPassword.PasswordChar = '*';
            this.CCPassword.Placeholder = "Contrasenya";
            this.CCPassword.Size = new System.Drawing.Size(191, 20);
            this.CCPassword.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 327);
            this.Controls.Add(this.CCPassword);
            this.Controls.Add(this.CCLogin);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private CustomControl.CustomTextBox CCLogin;
        private CustomControl.CustomTextBox CCPassword;
    }
}