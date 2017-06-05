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
    public partial class Home : Form
    {
        private ShoppingCart shoppingCart = new ShoppingCart();
        private static int user_id = -1;

        public Home()
        {
            InitializeComponent();
        }

        private void createAnAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createAnAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            error_message.Visible = false;
            account_error.Visible = false;
            CreateAccount account = new CreateAccount();
            account.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            error_message.Visible = false;
            account_error.Visible = false;
            Login login = new WindowsFormsApplication1.Login();
            login.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            error_message.Visible = false;
            account_error.Visible = false;
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var items = context.ITEMs.Select(i => i).OrderBy(i => i.title).ToList();
                int row = 0;
                int col = 0;
                foreach (var x in items)
                {
                    //create titel label
                    Label title = new Label { Text = "\n" + x.title, Anchor = AnchorStyles.Left, AutoSize = true };
                    title.Font = new Font("Calibri", 18, FontStyle.Bold | FontStyle.Underline);
                    title.ForeColor = System.Drawing.Color.Green;

                    //create description and price label
                    Label desc = new Label() { Text = x.description + "\nPrice: $" + x.price, Anchor = AnchorStyles.Left, AutoSize = true };
                    desc.Font = new Font("Calibri", 13);

                    //add labels to the table
                    item_table.Controls.Add(title, col, row);
                    item_table.Controls.Add(desc, col, (row + 1));

                    //crate button and add to the table
                    Button button = new Button() { Text = "Add To Cart", Name = x.id.ToString(), Anchor = AnchorStyles.Left, AutoSize = true };
                    button.Click += new EventHandler(AddToCard);
                    item_table.Controls.Add(button, col, (row + 2));

                    if (col == 2)
                    {
                        row += 3;
                        col = 0;
                    }
                    else { col++; }
                }
            }
        }

        private void AddToCard(object sender, EventArgs e)
        {
            if(user_id == -1)
            {
                error_message.Visible = true;
            }
            else
            {
                error_message.Visible = false;
                Button button = ((Button)sender);
                using (DataClasses1DataContext context = new DataClasses1DataContext())
                {
                    var item = context.ITEMs.Where(i => i.id.ToString() == button.Name).First();
                    shoppingCart.AddItem(item);
                }
            }       
        }

        private void shoppingCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.Show();
        }

        public static int UserID
        {
            get { return user_id; }
            set { user_id = value; }
        }

        private void makeAPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user_id == -1)
            {
                account_error.Visible = true;
            }
            else
            {
                account_error.Visible = false;
                MakePayment payment = new MakePayment();
                payment.Show();
            }
        }

        private void paymentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user_id == -1)
            {
                account_error.Visible = true;
            }
            else
            {
                account_error.Visible = false;
                PaymentHistory payment = new PaymentHistory();
                payment.Show();
            }
        }

        private void orderHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user_id == -1)
            {
                account_error.Visible = true;
            }
            else
            {
                account_error.Visible = false;
                OrderHistory order = new OrderHistory();
                order.Show();
            }
        }
    }
}