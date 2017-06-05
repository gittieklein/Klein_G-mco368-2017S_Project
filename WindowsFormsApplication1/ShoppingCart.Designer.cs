namespace WindowsFormsApplication1
{
    partial class ShoppingCart
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
            this.cart = new System.Windows.Forms.Label();
            this.checkout = new System.Windows.Forms.Button();
            this.total_price = new System.Windows.Forms.Label();
            this.balance_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 65);
            this.label1.TabIndex = 41;
            this.label1.Text = "Your Cart";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cart
            // 
            this.cart.AutoSize = true;
            this.cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cart.Location = new System.Drawing.Point(81, 138);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(0, 24);
            this.cart.TabIndex = 42;
            // 
            // checkout
            // 
            this.checkout.BackColor = System.Drawing.Color.Green;
            this.checkout.ForeColor = System.Drawing.Color.White;
            this.checkout.Location = new System.Drawing.Point(629, 135);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(129, 38);
            this.checkout.TabIndex = 43;
            this.checkout.Text = "CHECKOUT";
            this.checkout.UseVisualStyleBackColor = false;
            this.checkout.Click += new System.EventHandler(this.checkout_Click);
            // 
            // total_price
            // 
            this.total_price.AutoSize = true;
            this.total_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_price.Location = new System.Drawing.Point(624, 90);
            this.total_price.Name = "total_price";
            this.total_price.Size = new System.Drawing.Size(62, 25);
            this.total_price.TabIndex = 44;
            this.total_price.Text = "Total:";
            // 
            // balance_error
            // 
            this.balance_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance_error.ForeColor = System.Drawing.Color.Red;
            this.balance_error.Location = new System.Drawing.Point(624, 203);
            this.balance_error.Name = "balance_error";
            this.balance_error.Size = new System.Drawing.Size(182, 300);
            this.balance_error.TabIndex = 45;
            this.balance_error.Text = "*You must pay your balance to make another purchase";
            // 
            // ShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(844, 525);
            this.Controls.Add(this.balance_error);
            this.Controls.Add(this.total_price);
            this.Controls.Add(this.checkout);
            this.Controls.Add(this.cart);
            this.Controls.Add(this.label1);
            this.Name = "ShoppingCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShoppingCart";
            this.Load += new System.EventHandler(this.ShoppingCart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cart;
        private System.Windows.Forms.Button checkout;
        private System.Windows.Forms.Label total_price;
        private System.Windows.Forms.Label balance_error;
    }
}