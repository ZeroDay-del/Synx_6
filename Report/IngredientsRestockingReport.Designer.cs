namespace CAFE101.Business
{
    partial class IngredientsRestockingReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientsRestockingReport));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.date_label_1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.login_as_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.profile_panel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.date_label_1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.login_as_label);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.profile_panel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1137, 542);
            this.panel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(-1708, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(4597, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(25, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 405);
            this.panel1.TabIndex = 7;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(27, 18);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(916, 322);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
       //     this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // date_label_1
            // 
            this.date_label_1.AutoSize = true;
            this.date_label_1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label_1.ForeColor = System.Drawing.Color.Transparent;
            this.date_label_1.Location = new System.Drawing.Point(1562, 23);
            this.date_label_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date_label_1.Name = "date_label_1";
            this.date_label_1.Size = new System.Drawing.Size(64, 28);
            this.date_label_1.TabIndex = 6;
            this.date_label_1.Text = "Date";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 88);
            this.panel3.TabIndex = 5;
            // 
            // login_as_label
            // 
            this.login_as_label.AutoSize = true;
            this.login_as_label.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_as_label.ForeColor = System.Drawing.Color.Transparent;
            this.login_as_label.Location = new System.Drawing.Point(1344, 34);
            this.login_as_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login_as_label.Name = "login_as_label";
            this.login_as_label.Size = new System.Drawing.Size(103, 28);
            this.login_as_label.TabIndex = 2;
            this.login_as_label.Text = "Manager";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1344, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logged In As:";
            // 
            // profile_panel
            // 
            this.profile_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profile_panel.BackgroundImage")));
            this.profile_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profile_panel.Location = new System.Drawing.Point(1250, 0);
            this.profile_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profile_panel.Name = "profile_panel";
            this.profile_panel.Size = new System.Drawing.Size(86, 88);
            this.profile_panel.TabIndex = 0;
            // 
            // IngredientsRestockingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 542);
            this.Controls.Add(this.panel2);
            this.Name = "IngredientsRestockingReport";
            this.Text = " ";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label date_label_1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label login_as_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel profile_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}