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
    public partial class OrderHistory : Form
    {
        public OrderHistory()
        {
            InitializeComponent();
        }

        private void radio_date_CheckedChanged(object sender, EventArgs e)
        {
            date_start.Enabled = true;
            date_end.Enabled = true;
            to_price.Enabled = false;
            from_price.Enabled = false;
            filter.Enabled = true;

        }

        private void radio_price_CheckedChanged(object sender, EventArgs e)
        {
            date_start.Enabled = false;
            date_end.Enabled = false;
            to_price.Enabled = true;
            from_price.Enabled = true;
            filter.Enabled = true;

        }

        private void onclick_nofilter(object sender, EventArgs e)
        {
            date_start.Enabled = false;
            date_end.Enabled = false;
            to_price.Enabled = false;
            from_price.Enabled = false;
            filter.Enabled = false;

            orders.Text = "";

            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                foreach (var order in context.ORDERs.Where(i => i.account_id == Home.UserID)
                                                                     .OrderByDescending(i => i.date))
                {
                    orders.Text += "Order Number: " + order.id + "\nOrder Date: " + order.date 
                        + "\nToal: $" + order.total_cost + "\n";

                    foreach (var order_line in context.ORDER_LINEs.Where(n => n.order_id == order.id))
                    {
                        ITEM item = context.ITEMs.First(i => i.id == order_line.item_id);
                        orders.Text += "\n--Item: " + item.title + 
                            "\n--Quantity: " + order_line.quantity +
                            "\n--Price: $" + (item.price) + 
                            "\n--Total Price: $" + (order_line.quantity * item.price) + "\n";
                    }
                    orders.Text += "\n\n";
                }
            }
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {
            filter.Enabled = false;
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                foreach (var order in context.ORDERs.Where(i => i.account_id == Home.UserID)
                                                                          .OrderByDescending(i => i.date))
                {
                    orders.Text += "Order Number: " + order.id + "\nOrder Date: " + order.date
                        + "\nToal: $" + order.total_cost + "\n";

                    foreach (var order_line in context.ORDER_LINEs.Where(n => n.order_id == order.id))
                    {
                        ITEM item = context.ITEMs.First(i => i.id == order_line.item_id);
                        orders.Text += "\n--Item: " + item.title +
                            "\n--Quantity: " + order_line.quantity +
                            "\n--Price: $" + (item.price) +
                            "\n--Total Price: $" + (order_line.quantity * item.price) + "\n";
                    }
                    orders.Text += "\n\n";
                }
            }
        }

        private void filter_Click(object sender, EventArgs e)
        {
            validate.Text = "";
            if (radio_date.Checked)
            {
                orders.Text = "";
                String start = date_start.Text;
                String end = date_end.Text;
                DateTime start_date;
                DateTime end_date;
                Boolean success1, success2;
                success1 = DateTime.TryParse(start, out start_date);
                success2 = DateTime.TryParse(end, out end_date);

                if(success1 && success2)
                {
                    using (DataClasses1DataContext context = new DataClasses1DataContext())
                    {
                        foreach (var order in context.ORDERs.Where(i => i.account_id == Home.UserID)
                                .Where(o => DateTime.Compare(o.date, start_date) >= 0 && DateTime.Compare(o.date, end_date) <= 0)
                                .OrderByDescending(i => i.date))
                        {
                            orders.Text += "Order Number: " + order.id + "\nOrder Date: " + order.date
                                + "\nToal: $" + order.total_cost + "\n";

                            foreach (var order_line in context.ORDER_LINEs.Where(n => n.order_id == order.id))
                            {
                                ITEM item = context.ITEMs.First(i => i.id == order_line.item_id);
                                orders.Text += "\n--Item: " + item.title +
                                    "\n--Quantity: " + order_line.quantity +
                                    "\n--Price: $" + (item.price) +
                                    "\n--Total Price: $" + (order_line.quantity * item.price) + "\n";
                            }
                            orders.Text += "\n\n";
                        }
                    }
                }
                else
                {
                    validate.Text = "*Please enter valid data";
                }

            }
            else
            {
                orders.Text = "";
                String from = from_price.Text;
                String to = to_price.Text;
                decimal fprice;
                decimal tprice;
                Boolean success1, success2;
                success1 = Decimal.TryParse(from, out fprice);
                success2 = Decimal.TryParse(to, out tprice);
                Console.WriteLine(fprice);
                Console.WriteLine(tprice);

                if (success1 && success2)
                {
                    using (DataClasses1DataContext context = new DataClasses1DataContext())
                    {
                        foreach (var order in context.ORDERs.Where(i => i.account_id == Home.UserID)
                                .Where(o => (o.total_cost >= fprice && o.total_cost <= tprice))
                                .OrderByDescending(i => i.date))
                        {
                            orders.Text += "Order Number: " + order.id + "\nOrder Date: " + order.date
                                + "\nToal: $" + order.total_cost + "\n";

                            foreach (var order_line in context.ORDER_LINEs.Where(n => n.order_id == order.id))
                            {
                                ITEM item = context.ITEMs.First(i => i.id == order_line.item_id);
                                orders.Text += "\n--Item: " + item.title +
                                    "\n--Quantity: " + order_line.quantity +
                                    "\n--Price: $" + (item.price) +
                                    "\n--Total Price: $" + (order_line.quantity * item.price) + "\n";
                            }
                            orders.Text += "\n\n";
                        }
                    }
                }
                else
                {
                    validate.Text = "*Please enter valid data";
                }
            }
        }
    }
}
