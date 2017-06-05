namespace WindowsFormsApplication1
{
    partial class OrderHistory
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
            this.radio_date = new System.Windows.Forms.RadioButton();
            this.radio_price = new System.Windows.Forms.RadioButton();
            this.date_start = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.from_price = new System.Windows.Forms.TextBox();
            this.to_price = new System.Windows.Forms.TextBox();
            this.radio_none = new System.Windows.Forms.RadioButton();
            this.orders = new System.Windows.Forms.Label();
            this.filter = new System.Windows.Forms.Button();
            this.validate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(299, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 65);
            this.label1.TabIndex = 42;
            this.label1.Text = "Order History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radio_date
            // 
            this.radio_date.AutoSize = true;
            this.radio_date.Location = new System.Drawing.Point(76, 123);
            this.radio_date.Name = "radio_date";
            this.radio_date.Size = new System.Drawing.Size(160, 21);
            this.radio_date.TabIndex = 43;
            this.radio_date.Text = "Filter By Date Range";
            this.radio_date.UseVisualStyleBackColor = true;
            this.radio_date.CheckedChanged += new System.EventHandler(this.radio_date_CheckedChanged);
            // 
            // radio_price
            // 
            this.radio_price.AutoSize = true;
            this.radio_price.Location = new System.Drawing.Point(76, 150);
            this.radio_price.Name = "radio_price";
            this.radio_price.Size = new System.Drawing.Size(162, 21);
            this.radio_price.TabIndex = 44;
            this.radio_price.Text = "Filter By Price Range";
            this.radio_price.UseVisualStyleBackColor = true;
            this.radio_price.CheckedChanged += new System.EventHandler(this.radio_price_CheckedChanged);
            // 
            // date_start
            // 
            this.date_start.Enabled = false;
            this.date_start.Location = new System.Drawing.Point(160, 199);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(200, 22);
            this.date_start.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Start date: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "End date:";
            // 
            // date_end
            // 
            this.date_end.Enabled = false;
            this.date_end.Location = new System.Drawing.Point(467, 197);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(200, 22);
            this.date_end.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "From price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "To price:";
            // 
            // from_price
            // 
            this.from_price.Enabled = false;
            this.from_price.Location = new System.Drawing.Point(160, 239);
            this.from_price.Name = "from_price";
            this.from_price.Size = new System.Drawing.Size(200, 22);
            this.from_price.TabIndex = 51;
            // 
            // to_price
            // 
            this.to_price.Enabled = false;
            this.to_price.Location = new System.Drawing.Point(467, 240);
            this.to_price.Name = "to_price";
            this.to_price.Size = new System.Drawing.Size(200, 22);
            this.to_price.TabIndex = 52;
            // 
            // radio_none
            // 
            this.radio_none.AutoSize = true;
            this.radio_none.Checked = true;
            this.radio_none.Location = new System.Drawing.Point(76, 96);
            this.radio_none.Name = "radio_none";
            this.radio_none.Size = new System.Drawing.Size(77, 21);
            this.radio_none.TabIndex = 53;
            this.radio_none.TabStop = true;
            this.radio_none.Text = "View All";
            this.radio_none.UseVisualStyleBackColor = true;
            this.radio_none.CheckedChanged += new System.EventHandler(this.onclick_nofilter);
            // 
            // orders
            // 
            this.orders.AutoSize = true;
            this.orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders.Location = new System.Drawing.Point(82, 309);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(0, 24);
            this.orders.TabIndex = 54;
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(688, 197);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(75, 24);
            this.filter.TabIndex = 55;
            this.filter.Text = "Filter";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // validate
            // 
            this.validate.AutoSize = true;
            this.validate.ForeColor = System.Drawing.Color.Red;
            this.validate.Location = new System.Drawing.Point(695, 245);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(0, 17);
            this.validate.TabIndex = 56;
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(940, 543);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.radio_none);
            this.Controls.Add(this.to_price);
            this.Controls.Add(this.from_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date_end);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_start);
            this.Controls.Add(this.radio_price);
            this.Controls.Add(this.radio_date);
            this.Controls.Add(this.label1);
            this.Name = "OrderHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderHistory";
            this.Load += new System.EventHandler(this.OrderHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_date;
        private System.Windows.Forms.RadioButton radio_price;
        private System.Windows.Forms.DateTimePicker date_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_end;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox from_price;
        private System.Windows.Forms.TextBox to_price;
        private System.Windows.Forms.RadioButton radio_none;
        private System.Windows.Forms.Label orders;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.Label validate;
    }
}