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
    public partial class ShoppingCart : Form
    {
        private static Dictionary<int, int> shoppingCart = new Dictionary<int, int>();
        private static decimal total;
        private const int MAX_BALANCE = 5000;

        public ShoppingCart()
        {
            InitializeComponent();
        }

        private void ShoppingCart_Load(object sender, EventArgs e)
        {
            balance_error.Visible = false;
            if (shoppingCart.Count == 0)
            {
                cart.Text = "Your shopping cart is empty";
                checkout.Visible = false;
            }
            else
            {
                checkout.Visible = true;
                using (DataClasses1DataContext context = new DataClasses1DataContext())
                {
                   
                    foreach (KeyValuePair<int, int> kv in shoppingCart)
                    {                     
                        var item = context.ITEMs.Where(i => kv.Key == i.id).First();
                        cart.Text += kv.Value + " \t" + item.title + "\n$" + (item.price * kv.Value) +"\n\n";
                    }
                }
            }

            total_price.Text += " $" + total;
        }

        public void AddItem(ITEM item)
        {
            if (shoppingCart.ContainsKey(item.id))
            {
                shoppingCart[item.id] += 1;
            }
            else
            {
                shoppingCart.Add(item.id, 1);
            }
            total += item.price;
        }

        private void checkout_Click(object sender, EventArgs e)
        {
            
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                ACCOUNT user = context.ACCOUNTs.First(i => i.id == Home.UserID);
                decimal balance = user.balance;

                if(balance + total <= MAX_BALANCE)
                {
                    //update the balance in the database
                    user.balance += total;
                    context.SubmitChanges();

                    //add the order to the database
                    ORDER order = new ORDER();
                    // fields to be insert
                    order.account_id = user.id;
                    order.total_cost = total;
                    order.date = DateTime.Now;
                    context.ORDERs.InsertOnSubmit(order);
                    // executes the commands to implement the changes to the database
                    context.SubmitChanges();

                    int order_id = order.id;

                    //add the order-line to the database
                    foreach (KeyValuePair<int, int> item in shoppingCart)
                    {
                        ORDER_LINE order_line = new ORDER_LINE();
                        order_line.item_id = item.Key;
                        order_line.quantity = item.Value;
                        order_line.order_id = order_id;
                        context.ORDER_LINEs.InsertOnSubmit(order_line);
                        context.SubmitChanges();
                    }

                    //empty the shopping cart
                    shoppingCart.Clear();
                    total = 0;

                    cart.Text = "Thank you for your purchase. Your balance is now $" + user.balance;
                }
                else
                {
                    balance_error.Visible = true;
                }
            }
        }
    }
}