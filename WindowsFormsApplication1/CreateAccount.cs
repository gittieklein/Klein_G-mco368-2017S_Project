using DB_Console;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            String firstname = t_firstname.Text;
            String lastname = t_lastname.Text;
            String email = t_email.Text;
            String password = t_password.Text;


            //create boolean variable that could be used to check if the account is ready to be created
            bool fname_ok = false;
            bool lname_ok = false;
            bool email_ok = false;
            bool password_ok = false;

            if (firstname.Length == 0)
                fname_required.Text = "*Required Field";
            else
            {
                fname_required.Text = "*";
                fname_ok = true;
            }
               
            if (lastname.Length == 0)
                lname_required.Text = "*Required Field";
            else
            {
                lname_required.Text = "*";
                lname_ok = true;
            }   

            if (password.Length == 0)
                password_required.Text = "*Required Field";
            else
            {
                password_required.Text = "*";
                password_ok = true;
            }
                
            if (email.Length == 0)
                email_required.Text = "*Required Field";
            else
            {
               // email_required.Visible = false;

                //validate the email address
                string pattern = @"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$";
                System.Text.RegularExpressions.Match match = Regex.Match(email.Trim(), pattern, RegexOptions.IgnoreCase);

                if (!match.Success)
                    email_required.Text = "*Invalid Email";
                else
                {
                    email_required.Text = "*";

                    //check that there is no account in the db with the same email
                    using (DataClasses1DataContext context = new DataClasses1DataContext())
                    {
                        var test = context.ACCOUNTs.Any(i => i.email == email);
                        if (test)
                            duplicate_email.Visible = true;
                        else
                        {
                            duplicate_email.Visible = false;
                            email_ok = true;
                        }     
                    }

                }
            }

            //if all the fields are ok, add the user to the database
            if(fname_ok && lname_ok && email_ok && password_ok)
            {
                using (DataClasses1DataContext context = new DataClasses1DataContext())
                {
                    ACCOUNT acct = new ACCOUNT();
                    // fields to be insert
                    acct.first_name = firstname;
                    acct.last_name = lastname;
                    acct.email = email;
                    acct.password = password;
                    acct.balance = 0;   //start with a balance of 0
                    context.ACCOUNTs.InsertOnSubmit(acct);
                    // executes the commands to implement the changes to the database
                    context.SubmitChanges();

                    Home.UserID = context.ACCOUNTs.Where(i => i.email == email).Select(i => i.id).First();
                }

                //close the window after the user created an account
                this.Close();
            }
        }
    }
}
