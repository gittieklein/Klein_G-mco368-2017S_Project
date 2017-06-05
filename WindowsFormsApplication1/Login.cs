using DB_Console;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            String email = t_email.Text;
            String password = t_password.Text;

            //create boolean variable that could be used to check if the account is ready to be created  
            bool email_ok = false;
            bool password_ok = false;

            if (email.Length == 0)
                email_required.Text = "*Required Field";
            else
            {
                email_required.Text = "*";
                email_ok = true;
            }

            if (password.Length == 0)
                password_required.Text = "*Required Field";
            else
            {
                password_required.Text = "*";
                password_ok = true;
            }

            //if the email and password are both entered, check if the account exists
            if (email_ok && password_ok)
            {
                using (DataClasses1DataContext context = new DataClasses1DataContext())
                {
                    var test = context.ACCOUNTs.Any(i => i.email == email && i.password == password);
                    if (test)
                    {
                        account_exist.Visible = false;
                        Home.UserID = context.ACCOUNTs.Where(i => i.email == email).Select(i => i.id).First();
                        this.Close();                       
                    }
                    else
                    {
                        account_exist.Visible = true;
                    }
                }               
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

       
    }
}
