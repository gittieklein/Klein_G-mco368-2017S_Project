namespace WindowsFormsApplication1
{
    partial class MakePayment
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
            this.balance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amount_pay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Location = new System.Drawing.Point(328, 136);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(0, 17);
            this.balance.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(94, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 65);
            this.label1.TabIndex = 42;
            this.label1.Text = "Make a Payment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Levenim MT", 12F);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(120, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 27);
            this.label2.TabIndex = 43;
            this.label2.Text = "Payment Amount:";
            // 
            // amount_pay
            // 
            this.amount_pay.Location = new System.Drawing.Point(326, 170);
            this.amount_pay.Name = "amount_pay";
            this.amount_pay.Size = new System.Drawing.Size(140, 22);
            this.amount_pay.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Levenim MT", 12F);
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(120, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 27);
            this.label3.TabIndex = 45;
            this.label3.Text = "Amount Due:";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Levenim MT", 12F);
            this.submit.ForeColor = System.Drawing.Color.Green;
            this.submit.Location = new System.Drawing.Point(234, 250);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(111, 33);
            this.submit.TabIndex = 47;
            this.submit.Text = "Submit Payment";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.ForeColor = System.Drawing.Color.Red;
            this.number.Location = new System.Drawing.Point(199, 219);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(0, 17);
            this.number.TabIndex = 49;
            // 
            // MakePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 341);
            this.Controls.Add(this.number);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amount_pay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.balance);
            this.Name = "MakePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make a Payment";
            this.Load += new System.EventHandler(this.MakePayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amount_pay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label number;
    }
}