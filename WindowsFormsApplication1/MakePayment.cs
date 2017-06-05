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
    public partial class MakePayment : Form
    {
        public MakePayment()
        {
            InitializeComponent();
        }

        private void MakePayment_Load(object sender, EventArgs e)
        {

            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                ACCOUNT a = context.ACCOUNTs.First(i => i.id == Home.UserID);
                balance.Text = "$" + a.balance;
            }

        }

        private void submit_Click(object sender, EventArgs e)
        {

            decimal amount;
            bool success = Decimal.TryParse(amount_pay.Text, out amount);
            if (success && amount > 0)
            {
                number.Text = "";

                using (DataClasses1DataContext context = new DataClasses1DataContext())
                {
                    ACCOUNT user = context.ACCOUNTs.First(i => i.id == Home.UserID);
                    user.balance -= amount;

                    PAYMENT payment = new PAYMENT();
                    payment.amount = amount;
                    payment.date = DateTime.Now;
                    payment.account_id = user.id;
                    context.PAYMENTs.InsertOnSubmit(payment);
                    context.SubmitChanges();

                }

                this.Close();

            }

        }
    }
}
