namespace CAFE101.Business
{
    partial class Payment_Method
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.back_btn = new System.Windows.Forms.Button();
            this.payment_lbl = new System.Windows.Forms.Label();
            this.card_payment = new System.Windows.Forms.Button();
            this.cash_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CAFE101.Properties.Resources.black_red_art;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.back_btn);
            this.panel1.Controls.Add(this.payment_lbl);
            this.panel1.Controls.Add(this.card_payment);
            this.panel1.Controls.Add(this.cash_button);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 252);
            this.panel1.TabIndex = 0;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.Red;
            this.back_btn.Location = new System.Drawing.Point(104, 166);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(110, 48);
            this.back_btn.TabIndex = 3;
            this.back_btn.Text = "BACK";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // payment_lbl
            // 
            this.payment_lbl.AutoSize = true;
            this.payment_lbl.BackColor = System.Drawing.Color.Transparent;
            this.payment_lbl.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_lbl.ForeColor = System.Drawing.Color.White;
            this.payment_lbl.Location = new System.Drawing.Point(69, 28);
            this.payment_lbl.Name = "payment_lbl";
            this.payment_lbl.Size = new System.Drawing.Size(178, 24);
            this.payment_lbl.TabIndex = 2;
            this.payment_lbl.Text = "PAYMENT METHOD";
            // 
            // card_payment
            // 
            this.card_payment.BackColor = System.Drawing.Color.Transparent;
            this.card_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.card_payment.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card_payment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.card_payment.Location = new System.Drawing.Point(179, 102);
            this.card_payment.Name = "card_payment";
            this.card_payment.Size = new System.Drawing.Size(110, 48);
            this.card_payment.TabIndex = 1;
            this.card_payment.Text = "CARD";
            this.card_payment.UseVisualStyleBackColor = false;
            // 
            // cash_button
            // 
            this.cash_button.BackColor = System.Drawing.Color.Transparent;
            this.cash_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cash_button.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_button.ForeColor = System.Drawing.Color.White;
            this.cash_button.Location = new System.Drawing.Point(31, 102);
            this.cash_button.Name = "cash_button";
            this.cash_button.Size = new System.Drawing.Size(110, 48);
            this.cash_button.TabIndex = 0;
            this.cash_button.Text = "CASH";
            this.cash_button.UseVisualStyleBackColor = false;
            this.cash_button.Click += new System.EventHandler(this.cash_button_Click);
            // 
            // Payment_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 255);
            this.Controls.Add(this.panel1);
            this.Name = "Payment_Method";
            this.Text = "Payment_Method";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label payment_lbl;
        private System.Windows.Forms.Button card_payment;
        private System.Windows.Forms.Button cash_button;
        private System.Windows.Forms.Button back_btn;
    }
}