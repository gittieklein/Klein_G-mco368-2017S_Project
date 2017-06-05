namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.submit_button = new System.Windows.Forms.Button();
            this.l_password = new System.Windows.Forms.Label();
            this.l_email = new System.Windows.Forms.Label();
            this.t_password = new System.Windows.Forms.TextBox();
            this.t_email = new System.Windows.Forms.TextBox();
            this.account_exist = new System.Windows.Forms.Label();
            this.email_required = new System.Windows.Forms.Label();
            this.password_required = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(240, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 65);
            this.label1.TabIndex = 41;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // submit_button
            // 
            this.submit_button.ForeColor = System.Drawing.Color.Green;
            this.submit_button.Location = new System.Drawing.Point(270, 295);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(101, 33);
            this.submit_button.TabIndex = 46;
            this.submit_button.Text = "Login";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // l_password
            // 
            this.l_password.AutoSize = true;
            this.l_password.Font = new System.Drawing.Font("Levenim MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_password.ForeColor = System.Drawing.Color.Green;
            this.l_password.Location = new System.Drawing.Point(129, 203);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(109, 27);
            this.l_password.TabIndex = 45;
            this.l_password.Text = "Password:";
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.Font = new System.Drawing.Font("Levenim MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_email.ForeColor = System.Drawing.Color.Green;
            this.l_email.Location = new System.Drawing.Point(129, 164);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(76, 27);
            this.l_email.TabIndex = 44;
            this.l_email.Text = "Email: ";
            // 
            // t_password
            // 
            this.t_password.Location = new System.Drawing.Point(260, 203);
            this.t_password.Name = "t_password";
            this.t_password.PasswordChar = '*';
            this.t_password.Size = new System.Drawing.Size(227, 22);
            this.t_password.TabIndex = 43;
            // 
            // t_email
            // 
            this.t_email.Location = new System.Drawing.Point(260, 169);
            this.t_email.Name = "t_email";
            this.t_email.Size = new System.Drawing.Size(227, 22);
            this.t_email.TabIndex = 42;
            // 
            // account_exist
            // 
            this.account_exist.AutoSize = true;
            this.account_exist.ForeColor = System.Drawing.Color.Red;
            this.account_exist.Location = new System.Drawing.Point(136, 257);
            this.account_exist.Name = "account_exist";
            this.account_exist.Size = new System.Drawing.Size(350, 17);
            this.account_exist.TabIndex = 47;
            this.account_exist.Text = "*There is no accoutn with the credentials you provided";
            this.account_exist.Visible = false;
            // 
            // email_required
            // 
            this.email_required.AutoSize = true;
            this.email_required.ForeColor = System.Drawing.Color.Red;
            this.email_required.Location = new System.Drawing.Point(493, 174);
            this.email_required.Name = "email_required";
            this.email_required.Size = new System.Drawing.Size(13, 17);
            this.email_required.TabIndex = 48;
            this.email_required.Text = "*";
            // 
            // password_required
            // 
            this.password_required.AutoSize = true;
            this.password_required.ForeColor = System.Drawing.Color.Red;
            this.password_required.Location = new System.Drawing.Point(493, 209);
            this.password_required.Name = "password_required";
            this.password_required.Size = new System.Drawing.Size(13, 17);
            this.password_required.TabIndex = 49;
            this.password_required.Text = "*";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 403);
            this.Controls.Add(this.password_required);
            this.Controls.Add(this.email_required);
            this.Controls.Add(this.account_exist);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.l_password);
            this.Controls.Add(this.l_email);
            this.Controls.Add(this.t_password);
            this.Controls.Add(this.t_email);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label l_password;
        private System.Windows.Forms.Label l_email;
        private System.Windows.Forms.TextBox t_password;
        private System.Windows.Forms.TextBox t_email;
        private System.Windows.Forms.Label account_exist;
        private System.Windows.Forms.Label email_required;
        private System.Windows.Forms.Label password_required;
    }
}