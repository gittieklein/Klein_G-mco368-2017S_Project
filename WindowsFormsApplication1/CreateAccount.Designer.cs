namespace WindowsFormsApplication1
{
    partial class CreateAccount
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
            this.duplicate_email = new System.Windows.Forms.Label();
            this.password_required = new System.Windows.Forms.Label();
            this.email_required = new System.Windows.Forms.Label();
            this.lname_required = new System.Windows.Forms.Label();
            this.fname_required = new System.Windows.Forms.Label();
            this.submit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.l_password = new System.Windows.Forms.Label();
            this.l_email = new System.Windows.Forms.Label();
            this.l_lastname = new System.Windows.Forms.Label();
            this.l_firstname = new System.Windows.Forms.Label();
            this.t_password = new System.Windows.Forms.TextBox();
            this.t_email = new System.Windows.Forms.TextBox();
            this.t_lastname = new System.Windows.Forms.TextBox();
            this.t_firstname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // duplicate_email
            // 
            this.duplicate_email.AutoSize = true;
            this.duplicate_email.ForeColor = System.Drawing.Color.Red;
            this.duplicate_email.Location = new System.Drawing.Point(286, 358);
            this.duplicate_email.Name = "duplicate_email";
            this.duplicate_email.Size = new System.Drawing.Size(278, 34);
            this.duplicate_email.TabIndex = 47;
            this.duplicate_email.Text = "*An Account Already Exists With This Email\r\n        Please Enter a New Email Addr" +
    "ess\r\n";
            this.duplicate_email.Visible = false;
            // 
            // password_required
            // 
            this.password_required.AutoSize = true;
            this.password_required.ForeColor = System.Drawing.Color.Red;
            this.password_required.Location = new System.Drawing.Point(589, 312);
            this.password_required.Name = "password_required";
            this.password_required.Size = new System.Drawing.Size(13, 17);
            this.password_required.TabIndex = 45;
            this.password_required.Text = "*";
            // 
            // email_required
            // 
            this.email_required.AutoSize = true;
            this.email_required.ForeColor = System.Drawing.Color.Red;
            this.email_required.Location = new System.Drawing.Point(589, 278);
            this.email_required.Name = "email_required";
            this.email_required.Size = new System.Drawing.Size(13, 17);
            this.email_required.TabIndex = 44;
            this.email_required.Text = "*";
            // 
            // lname_required
            // 
            this.lname_required.AutoSize = true;
            this.lname_required.ForeColor = System.Drawing.Color.Red;
            this.lname_required.Location = new System.Drawing.Point(589, 240);
            this.lname_required.Name = "lname_required";
            this.lname_required.Size = new System.Drawing.Size(13, 17);
            this.lname_required.TabIndex = 43;
            this.lname_required.Text = "*";
            // 
            // fname_required
            // 
            this.fname_required.AutoSize = true;
            this.fname_required.ForeColor = System.Drawing.Color.Red;
            this.fname_required.Location = new System.Drawing.Point(589, 200);
            this.fname_required.Name = "fname_required";
            this.fname_required.Size = new System.Drawing.Size(13, 17);
            this.fname_required.TabIndex = 42;
            this.fname_required.Text = "*";
            // 
            // submit_button
            // 
            this.submit_button.ForeColor = System.Drawing.Color.Green;
            this.submit_button.Location = new System.Drawing.Point(367, 415);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(152, 33);
            this.submit_button.TabIndex = 41;
            this.submit_button.Text = "Create Account";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(173, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 65);
            this.label1.TabIndex = 40;
            this.label1.Text = "Create An Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l_password
            // 
            this.l_password.AutoSize = true;
            this.l_password.Font = new System.Drawing.Font("Levenim MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_password.ForeColor = System.Drawing.Color.Green;
            this.l_password.Location = new System.Drawing.Point(225, 307);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(109, 27);
            this.l_password.TabIndex = 39;
            this.l_password.Text = "Password:";
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.Font = new System.Drawing.Font("Levenim MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_email.ForeColor = System.Drawing.Color.Green;
            this.l_email.Location = new System.Drawing.Point(225, 268);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(76, 27);
            this.l_email.TabIndex = 38;
            this.l_email.Text = "Email: ";
            // 
            // l_lastname
            // 
            this.l_lastname.AutoSize = true;
            this.l_lastname.Font = new System.Drawing.Font("Levenim MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_lastname.ForeColor = System.Drawing.Color.Green;
            this.l_lastname.Location = new System.Drawing.Point(225, 233);
            this.l_lastname.Name = "l_lastname";
            this.l_lastname.Size = new System.Drawing.Size(123, 27);
            this.l_lastname.TabIndex = 37;
            this.l_lastname.Text = "Last Name:";
            // 
            // l_firstname
            // 
            this.l_firstname.AutoSize = true;
            this.l_firstname.Font = new System.Drawing.Font("Levenim MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_firstname.ForeColor = System.Drawing.Color.Green;
            this.l_firstname.Location = new System.Drawing.Point(225, 196);
            this.l_firstname.Name = "l_firstname";
            this.l_firstname.Size = new System.Drawing.Size(120, 27);
            this.l_firstname.TabIndex = 36;
            this.l_firstname.Text = "First Name:";
            // 
            // t_password
            // 
            this.t_password.Location = new System.Drawing.Point(356, 307);
            this.t_password.Name = "t_password";
            this.t_password.PasswordChar = '*';
            this.t_password.Size = new System.Drawing.Size(227, 22);
            this.t_password.TabIndex = 35;
            // 
            // t_email
            // 
            this.t_email.Location = new System.Drawing.Point(356, 273);
            this.t_email.Name = "t_email";
            this.t_email.Size = new System.Drawing.Size(227, 22);
            this.t_email.TabIndex = 34;
            // 
            // t_lastname
            // 
            this.t_lastname.Location = new System.Drawing.Point(356, 235);
            this.t_lastname.Name = "t_lastname";
            this.t_lastname.Size = new System.Drawing.Size(227, 22);
            this.t_lastname.TabIndex = 33;
            // 
            // t_firstname
            // 
            this.t_firstname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.t_firstname.Location = new System.Drawing.Point(356, 196);
            this.t_firstname.Name = "t_firstname";
            this.t_firstname.Size = new System.Drawing.Size(227, 22);
            this.t_firstname.TabIndex = 32;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 563);
            this.Controls.Add(this.duplicate_email);
            this.Controls.Add(this.password_required);
            this.Controls.Add(this.email_required);
            this.Controls.Add(this.lname_required);
            this.Controls.Add(this.fname_required);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_password);
            this.Controls.Add(this.l_email);
            this.Controls.Add(this.l_lastname);
            this.Controls.Add(this.l_firstname);
            this.Controls.Add(this.t_password);
            this.Controls.Add(this.t_email);
            this.Controls.Add(this.t_lastname);
            this.Controls.Add(this.t_firstname);
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountLogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label duplicate_email;
        private System.Windows.Forms.Label password_required;
        private System.Windows.Forms.Label email_required;
        private System.Windows.Forms.Label lname_required;
        private System.Windows.Forms.Label fname_required;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_password;
        private System.Windows.Forms.Label l_email;
        private System.Windows.Forms.Label l_lastname;
        private System.Windows.Forms.Label l_firstname;
        private System.Windows.Forms.TextBox t_password;
        private System.Windows.Forms.TextBox t_email;
        private System.Windows.Forms.TextBox t_lastname;
        private System.Windows.Forms.TextBox t_firstname;
    }
}