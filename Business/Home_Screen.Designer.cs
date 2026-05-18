namespace CAFE101
{
    partial class Home_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Screen));
            this.menu_tab = new System.Windows.Forms.TabControl();
            this.all_menu = new System.Windows.Forms.TabPage();
            this.all_menu_display = new System.Windows.Forms.FlowLayoutPanel();
            this.chow_page = new System.Windows.Forms.TabPage();
            this.chow_menu = new System.Windows.Forms.FlowLayoutPanel();
            this.drinks_page = new System.Windows.Forms.TabPage();
            this.drinks_menu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.search_menu = new System.Windows.Forms.TextBox();
            this.login_as_label = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.profile_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.help_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cart_label = new System.Windows.Forms.Label();
            this.ready_items_label = new System.Windows.Forms.Label();
            this.subt_label = new System.Windows.Forms.Label();
            this.subtotal_label = new System.Windows.Forms.Label();
            this.checkout_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.menu_tab.SuspendLayout();
            this.all_menu.SuspendLayout();
            this.chow_page.SuspendLayout();
            this.drinks_page.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_tab
            // 
            this.menu_tab.Controls.Add(this.all_menu);
            this.menu_tab.Controls.Add(this.chow_page);
            this.menu_tab.Controls.Add(this.drinks_page);
            this.menu_tab.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_tab.Location = new System.Drawing.Point(175, 82);
            this.menu_tab.Name = "menu_tab";
            this.menu_tab.SelectedIndex = 0;
            this.menu_tab.Size = new System.Drawing.Size(571, 519);
            this.menu_tab.TabIndex = 0;
            // 
            // all_menu
            // 
            this.all_menu.BackColor = System.Drawing.Color.Black;
            this.all_menu.Controls.Add(this.all_menu_display);
            this.all_menu.Location = new System.Drawing.Point(4, 24);
            this.all_menu.Name = "all_menu";
            this.all_menu.Padding = new System.Windows.Forms.Padding(3);
            this.all_menu.Size = new System.Drawing.Size(563, 491);
            this.all_menu.TabIndex = 0;
            this.all_menu.Text = "All";
            // 
            // all_menu_display
            // 
            this.all_menu_display.AutoScroll = true;
            this.all_menu_display.Location = new System.Drawing.Point(0, 0);
            this.all_menu_display.Name = "all_menu_display";
            this.all_menu_display.Size = new System.Drawing.Size(567, 485);
            this.all_menu_display.TabIndex = 0;
            // 
            // chow_page
            // 
            this.chow_page.BackColor = System.Drawing.Color.Black;
            this.chow_page.Controls.Add(this.chow_menu);
            this.chow_page.Location = new System.Drawing.Point(4, 24);
            this.chow_page.Name = "chow_page";
            this.chow_page.Padding = new System.Windows.Forms.Padding(3);
            this.chow_page.Size = new System.Drawing.Size(563, 491);
            this.chow_page.TabIndex = 1;
            this.chow_page.Text = "Chow";
            // 
            // chow_menu
            // 
            this.chow_menu.Location = new System.Drawing.Point(-4, 0);
            this.chow_menu.Name = "chow_menu";
            this.chow_menu.Size = new System.Drawing.Size(571, 447);
            this.chow_menu.TabIndex = 0;
            // 
            // drinks_page
            // 
            this.drinks_page.BackColor = System.Drawing.Color.Black;
            this.drinks_page.Controls.Add(this.drinks_menu);
            this.drinks_page.Location = new System.Drawing.Point(4, 24);
            this.drinks_page.Name = "drinks_page";
            this.drinks_page.Padding = new System.Windows.Forms.Padding(3);
            this.drinks_page.Size = new System.Drawing.Size(563, 491);
            this.drinks_page.TabIndex = 2;
            this.drinks_page.Text = "Drinks";
            // 
            // drinks_menu
            // 
            this.drinks_menu.Location = new System.Drawing.Point(-4, 0);
            this.drinks_menu.Name = "drinks_menu";
            this.drinks_menu.Size = new System.Drawing.Size(567, 443);
            this.drinks_menu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.date_label);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.search_menu);
            this.panel1.Controls.Add(this.login_as_label);
            this.panel1.Controls.Add(this.login_label);
            this.panel1.Controls.Add(this.profile_panel);
            this.panel1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 57);
            this.panel1.TabIndex = 1;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.ForeColor = System.Drawing.Color.Transparent;
            this.date_label.Location = new System.Drawing.Point(1082, 15);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(0, 19);
            this.date_label.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 57);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search Menu Item";
            // 
            // search_menu
            // 
            this.search_menu.BackColor = System.Drawing.Color.Black;
            this.search_menu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_menu.ForeColor = System.Drawing.Color.White;
            this.search_menu.Location = new System.Drawing.Point(529, 15);
            this.search_menu.Name = "search_menu";
            this.search_menu.Size = new System.Drawing.Size(225, 26);
            this.search_menu.TabIndex = 3;
            // 
            // login_as_label
            // 
            this.login_as_label.AutoSize = true;
            this.login_as_label.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_as_label.ForeColor = System.Drawing.Color.Transparent;
            this.login_as_label.Location = new System.Drawing.Point(896, 22);
            this.login_as_label.Name = "login_as_label";
            this.login_as_label.Size = new System.Drawing.Size(72, 19);
            this.login_as_label.TabIndex = 2;
            this.login_as_label.Text = "Cashier";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.ForeColor = System.Drawing.Color.Transparent;
            this.login_label.Location = new System.Drawing.Point(896, 3);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(126, 19);
            this.login_label.TabIndex = 1;
            this.login_label.Text = "Logged In As:";
            // 
            // profile_panel
            // 
            this.profile_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profile_panel.BackgroundImage")));
            this.profile_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profile_panel.Location = new System.Drawing.Point(833, 0);
            this.profile_panel.Name = "profile_panel";
            this.profile_panel.Size = new System.Drawing.Size(57, 57);
            this.profile_panel.TabIndex = 0;
            this.profile_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.profile_panel_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(0, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1249, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Transparent;
            this.panel15.Controls.Add(this.logout_btn);
            this.panel15.Controls.Add(this.help_btn);
            this.panel15.Controls.Add(this.home_btn);
            this.panel15.Location = new System.Drawing.Point(4, 82);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(165, 519);
            this.panel15.TabIndex = 3;
            // 
            // logout_btn
            // 
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("logout_btn.Image")));
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(8, 104);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(150, 31);
            this.logout_btn.TabIndex = 6;
            this.logout_btn.Text = "LOGOUT";
            this.logout_btn.UseVisualStyleBackColor = true;
            // 
            // help_btn
            // 
            this.help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_btn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_btn.ForeColor = System.Drawing.Color.White;
            this.help_btn.Image = ((System.Drawing.Image)(resources.GetObject("help_btn.Image")));
            this.help_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.help_btn.Location = new System.Drawing.Point(8, 67);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(150, 31);
            this.help_btn.TabIndex = 5;
            this.help_btn.Text = "HELP";
            this.help_btn.UseVisualStyleBackColor = true;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.Transparent;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.ForeColor = System.Drawing.Color.Red;
            this.home_btn.Image = ((System.Drawing.Image)(resources.GetObject("home_btn.Image")));
            this.home_btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.home_btn.Location = new System.Drawing.Point(8, 30);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(150, 31);
            this.home_btn.TabIndex = 4;
            this.home_btn.Text = "HOME";
            this.home_btn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(752, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 176);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(757, 425);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(491, 176);
            this.dataGridView2.TabIndex = 5;
            // 
            // cart_label
            // 
            this.cart_label.AutoSize = true;
            this.cart_label.BackColor = System.Drawing.Color.Transparent;
            this.cart_label.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cart_label.ForeColor = System.Drawing.Color.White;
            this.cart_label.Location = new System.Drawing.Point(752, 94);
            this.cart_label.Name = "cart_label";
            this.cart_label.Size = new System.Drawing.Size(64, 28);
            this.cart_label.TabIndex = 6;
            this.cart_label.Text = "CART";
            // 
            // ready_items_label
            // 
            this.ready_items_label.AutoSize = true;
            this.ready_items_label.BackColor = System.Drawing.Color.Transparent;
            this.ready_items_label.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ready_items_label.ForeColor = System.Drawing.Color.White;
            this.ready_items_label.Location = new System.Drawing.Point(752, 394);
            this.ready_items_label.Name = "ready_items_label";
            this.ready_items_label.Size = new System.Drawing.Size(155, 28);
            this.ready_items_label.TabIndex = 7;
            this.ready_items_label.Text = "READY ITEMS";
            // 
            // subt_label
            // 
            this.subt_label.AutoSize = true;
            this.subt_label.BackColor = System.Drawing.Color.Transparent;
            this.subt_label.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subt_label.ForeColor = System.Drawing.Color.White;
            this.subt_label.Location = new System.Drawing.Point(752, 304);
            this.subt_label.Name = "subt_label";
            this.subt_label.Size = new System.Drawing.Size(129, 28);
            this.subt_label.TabIndex = 8;
            this.subt_label.Text = "SUBTOTAL:";
            // 
            // subtotal_label
            // 
            this.subtotal_label.AutoSize = true;
            this.subtotal_label.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal_label.ForeColor = System.Drawing.Color.White;
            this.subtotal_label.Location = new System.Drawing.Point(1159, 304);
            this.subtotal_label.Name = "subtotal_label";
            this.subtotal_label.Size = new System.Drawing.Size(51, 28);
            this.subtotal_label.TabIndex = 9;
            this.subtotal_label.Text = "R24";
            // 
            // checkout_btn
            // 
            this.checkout_btn.BackColor = System.Drawing.Color.Transparent;
            this.checkout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkout_btn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkout_btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.checkout_btn.Image = ((System.Drawing.Image)(resources.GetObject("checkout_btn.Image")));
            this.checkout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkout_btn.Location = new System.Drawing.Point(1098, 346);
            this.checkout_btn.Name = "checkout_btn";
            this.checkout_btn.Size = new System.Drawing.Size(150, 35);
            this.checkout_btn.TabIndex = 10;
            this.checkout_btn.Text = " CHECKOUT";
            this.checkout_btn.UseVisualStyleBackColor = false;
            this.checkout_btn.Click += new System.EventHandler(this.checkout_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.Transparent;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.ForeColor = System.Drawing.Color.Red;
            this.clear_btn.Image = ((System.Drawing.Image)(resources.GetObject("clear_btn.Image")));
            this.clear_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clear_btn.Location = new System.Drawing.Point(935, 346);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(150, 35);
            this.clear_btn.TabIndex = 11;
            this.clear_btn.Text = "  CLEAR CART";
            this.clear_btn.UseVisualStyleBackColor = false;
            // 
            // Home_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::CAFE101.Properties.Resources.black_red_art;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1251, 613);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.checkout_btn);
            this.Controls.Add(this.subtotal_label);
            this.Controls.Add(this.subt_label);
            this.Controls.Add(this.ready_items_label);
            this.Controls.Add(this.cart_label);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu_tab);
            this.Name = "Home_Screen";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Form_Load);
            this.menu_tab.ResumeLayout(false);
            this.all_menu.ResumeLayout(false);
            this.chow_page.ResumeLayout(false);
            this.drinks_page.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl menu_tab;
        private System.Windows.Forms.TabPage all_menu;
        private System.Windows.Forms.TabPage chow_page;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel profile_panel;
        private System.Windows.Forms.Label login_as_label;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage drinks_page;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button help_btn;
        private System.Windows.Forms.FlowLayoutPanel all_menu_display;
        private System.Windows.Forms.FlowLayoutPanel chow_menu;
        private System.Windows.Forms.FlowLayoutPanel drinks_menu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label cart_label;
        private System.Windows.Forms.Label ready_items_label;
        private System.Windows.Forms.Label subt_label;
        private System.Windows.Forms.Label subtotal_label;
        private System.Windows.Forms.Button checkout_btn;
        private System.Windows.Forms.Button clear_btn;
    }
}

