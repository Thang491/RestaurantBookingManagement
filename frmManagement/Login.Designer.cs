namespace frmManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtUser = new System.Windows.Forms.TextBox();
            txtPass = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(55, 56);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(55, 147);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.Location = new System.Drawing.Point(174, 51);
            txtUser.Margin = new System.Windows.Forms.Padding(2);
            txtUser.Name = "txtUser";
            txtUser.Size = new System.Drawing.Size(296, 27);
            txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new System.Drawing.Point(174, 142);
            txtPass.Margin = new System.Windows.Forms.Padding(2);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new System.Drawing.Size(296, 27);
            txtPass.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(376, 225);
            btnLogin.Margin = new System.Windows.Forms.Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(92, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(514, 319);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = System.Drawing.SystemColors.ControlText;
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
    }
}