namespace WindowsFormsApplication1
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createAnAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAnAccountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.shoppingCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item_table = new System.Windows.Forms.TableLayoutPanel();
            this.error_message = new System.Windows.Forms.Label();
            this.account_error = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Green;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAnAccountToolStripMenuItem,
            this.myAccountToolStripMenuItem,
            this.shoppingCartToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1095, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createAnAccountToolStripMenuItem
            // 
            this.createAnAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.createAnAccountToolStripMenuItem1});
            this.createAnAccountToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAnAccountToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.createAnAccountToolStripMenuItem.Name = "createAnAccountToolStripMenuItem";
            this.createAnAccountToolStripMenuItem.Size = new System.Drawing.Size(230, 32);
            this.createAnAccountToolStripMenuItem.Text = "Login/Create Account";
            this.createAnAccountToolStripMenuItem.Click += new System.EventHandler(this.createAnAccountToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.loginToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // createAnAccountToolStripMenuItem1
            // 
            this.createAnAccountToolStripMenuItem1.BackColor = System.Drawing.Color.Green;
            this.createAnAccountToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.createAnAccountToolStripMenuItem1.Name = "createAnAccountToolStripMenuItem1";
            this.createAnAccountToolStripMenuItem1.Size = new System.Drawing.Size(264, 32);
            this.createAnAccountToolStripMenuItem1.Text = "Create an Account";
            this.createAnAccountToolStripMenuItem1.Click += new System.EventHandler(this.createAnAccountToolStripMenuItem1_Click);
            // 
            // shoppingCartToolStripMenuItem
            // 
            this.shoppingCartToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.shoppingCartToolStripMenuItem.Name = "shoppingCartToolStripMenuItem";
            this.shoppingCartToolStripMenuItem.Size = new System.Drawing.Size(159, 32);
            this.shoppingCartToolStripMenuItem.Text = "Shopping Cart";
            this.shoppingCartToolStripMenuItem.Click += new System.EventHandler(this.shoppingCartToolStripMenuItem_Click);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitApplicationToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(175, 32);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // myAccountToolStripMenuItem
            // 
            this.myAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeAPaymentToolStripMenuItem,
            this.paymentHistoryToolStripMenuItem,
            this.orderHistoryToolStripMenuItem});
            this.myAccountToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myAccountToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            this.myAccountToolStripMenuItem.Size = new System.Drawing.Size(138, 32);
            this.myAccountToolStripMenuItem.Text = "My Account";
            // 
            // makeAPaymentToolStripMenuItem
            // 
            this.makeAPaymentToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.makeAPaymentToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.makeAPaymentToolStripMenuItem.Name = "makeAPaymentToolStripMenuItem";
            this.makeAPaymentToolStripMenuItem.Size = new System.Drawing.Size(383, 32);
            this.makeAPaymentToolStripMenuItem.Text = "Make a Payment/View Balance";
            this.makeAPaymentToolStripMenuItem.Click += new System.EventHandler(this.makeAPaymentToolStripMenuItem_Click);
            // 
            // paymentHistoryToolStripMenuItem
            // 
            this.paymentHistoryToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.paymentHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.paymentHistoryToolStripMenuItem.Name = "paymentHistoryToolStripMenuItem";
            this.paymentHistoryToolStripMenuItem.Size = new System.Drawing.Size(249, 32);
            this.paymentHistoryToolStripMenuItem.Text = "Payment History";
            this.paymentHistoryToolStripMenuItem.Click += new System.EventHandler(this.paymentHistoryToolStripMenuItem_Click);
            // 
            // orderHistoryToolStripMenuItem
            // 
            this.orderHistoryToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.orderHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.orderHistoryToolStripMenuItem.Name = "orderHistoryToolStripMenuItem";
            this.orderHistoryToolStripMenuItem.Size = new System.Drawing.Size(383, 32);
            this.orderHistoryToolStripMenuItem.Text = "Order History";
            this.orderHistoryToolStripMenuItem.Click += new System.EventHandler(this.orderHistoryToolStripMenuItem_Click);
            // 
            // item_table
            // 
            this.item_table.AutoScroll = true;
            this.item_table.ColumnCount = 3;
            this.item_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.item_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.item_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.item_table.Location = new System.Drawing.Point(12, 90);
            this.item_table.Name = "item_table";
            this.item_table.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.item_table.RowCount = 10;
            this.item_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.item_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.item_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.item_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.item_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.item_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.item_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.item_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.item_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.item_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.item_table.Size = new System.Drawing.Size(1071, 563);
            this.item_table.TabIndex = 3;
            // 
            // error_message
            // 
            this.error_message.AutoSize = true;
            this.error_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_message.ForeColor = System.Drawing.Color.Red;
            this.error_message.Location = new System.Drawing.Point(347, 53);
            this.error_message.Name = "error_message";
            this.error_message.Size = new System.Drawing.Size(415, 20);
            this.error_message.TabIndex = 4;
            this.error_message.Text = "*You must be logged in to add items to your cart";
            // 
            // account_error
            // 
            this.account_error.AutoSize = true;
            this.account_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_error.ForeColor = System.Drawing.Color.Red;
            this.account_error.Location = new System.Drawing.Point(347, 53);
            this.account_error.Name = "account_error";
            this.account_error.Size = new System.Drawing.Size(381, 20);
            this.account_error.TabIndex = 5;
            this.account_error.Text = "*You must be logged in to view your account";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1095, 674);
            this.Controls.Add(this.account_error);
            this.Controls.Add(this.error_message);
            this.Controls.Add(this.item_table);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createAnAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAnAccountToolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel item_table;
        private System.Windows.Forms.ToolStripMenuItem shoppingCartToolStripMenuItem;
        private System.Windows.Forms.Label error_message;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderHistoryToolStripMenuItem;
        private System.Windows.Forms.Label account_error;
    }
}

