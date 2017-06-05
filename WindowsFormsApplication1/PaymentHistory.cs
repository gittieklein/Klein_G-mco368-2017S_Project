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
    public partial class PaymentHistory : Form
    {
        public PaymentHistory()
        {
            InitializeComponent();
        }

        private void PaymentHistory_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                foreach (var pay in context.PAYMENTs.Where(i => i.account_id == Home.UserID))
                {
                    history_label.Text += "Payment number: " + pay.id + "\nDate: " + pay.date +
                        "\nPayment amount: $" + pay.amount + "\n\n";
                }
            }
        }
    }
}
