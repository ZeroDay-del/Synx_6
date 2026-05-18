namespace CAFE101.Business
{
    partial class Cash_form
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
            this.total_amt_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.email_text_box = new System.Windows.Forms.TextBox();
            this.process_payment_btn = new System.Windows.Forms.Button();
            this.payment_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CAFE101.Properties.Resources.black_red_art;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.back_btn);
            this.panel1.Controls.Add(this.total_amt_lbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.email_text_box);
            this.panel1.Controls.Add(this.process_payment_btn);
            this.panel1.Controls.Add(this.payment_lbl);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 252);
            this.panel1.TabIndex = 1;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.Red;
            this.back_btn.Location = new System.Drawing.Point(193, 164);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(110, 48);
            this.back_btn.TabIndex = 7;
            this.back_btn.Text = "BACK";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // total_amt_lbl
            // 
            this.total_amt_lbl.AutoSize = true;
            this.total_amt_lbl.BackColor = System.Drawing.Color.Transparent;
            this.total_amt_lbl.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_amt_lbl.ForeColor = System.Drawing.Color.White;
            this.total_amt_lbl.Location = new System.Drawing.Point(175, 30);
            this.total_amt_lbl.Name = "total_amt_lbl";
            this.total_amt_lbl.Size = new System.Drawing.Size(58, 24);
            this.total_amt_lbl.TabIndex = 6;
            this.total_amt_lbl.Text = "R120";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "TOTAL AMOUNT:";
            // 
            // email_text_box
            // 
            this.email_text_box.BackColor = System.Drawing.Color.Black;
            this.email_text_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_text_box.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_text_box.ForeColor = System.Drawing.Color.White;
            this.email_text_box.Location = new System.Drawing.Point(7, 104);
            this.email_text_box.Name = "email_text_box";
            this.email_text_box.Size = new System.Drawing.Size(182, 30);
            this.email_text_box.TabIndex = 4;
            // 
            // process_payment_btn
            // 
            this.process_payment_btn.BackColor = System.Drawing.Color.Transparent;
            this.process_payment_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.process_payment_btn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.process_payment_btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.process_payment_btn.Location = new System.Drawing.Point(11, 164);
            this.process_payment_btn.Name = "process_payment_btn";
            this.process_payment_btn.Size = new System.Drawing.Size(110, 48);
            this.process_payment_btn.TabIndex = 3;
            this.process_payment_btn.Text = "PROCESS";
            this.process_payment_btn.UseVisualStyleBackColor = false;
            // 
            // payment_lbl
            // 
            this.payment_lbl.AutoSize = true;
            this.payment_lbl.BackColor = System.Drawing.Color.Transparent;
            this.payment_lbl.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_lbl.ForeColor = System.Drawing.Color.White;
            this.payment_lbl.Location = new System.Drawing.Point(3, 77);
            this.payment_lbl.Name = "payment_lbl";
            this.payment_lbl.Size = new System.Drawing.Size(214, 24);
            this.payment_lbl.TabIndex = 2;
            this.payment_lbl.Text = "INPUT CASH AMOUNT";
            // 
            // Cash_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 255);
            this.Controls.Add(this.panel1);
            this.Name = "Cash_form";
            this.Text = "Cash_form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label payment_lbl;
        private System.Windows.Forms.Button process_payment_btn;
        private System.Windows.Forms.TextBox email_text_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label total_amt_lbl;
        private System.Windows.Forms.Button back_btn;
    }
}