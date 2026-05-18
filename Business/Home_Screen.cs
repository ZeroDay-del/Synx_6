using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using CAFE101.Business;

namespace CAFE101
{
    public partial class Home_Screen : Form
    {
        public Home_Screen()
        {
            InitializeComponent();
        }

        private void Home_Form_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            date_label.Text = now.ToString("dd MMMM yyyy");
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0,0,profile_panel.Width, profile_panel.Height);
            profile_panel.Region = new Region(path);
            CreateProductCard("original", "R15.00", "images/original.jpg");
            CreateProductCard("original", "R15.00", "images/original.jpg");
            CreateProductCard("original", "R15.00", "images/original.jpg");
            CreateProductCard("original", "R15.00", "images/original.jpg");
            CreateProductCard("original", "R15.00", "images/original.jpg");
            CreateProductCard("original", "R15.00", "images/original.jpg");
            CreateProductCard("original", "R15.00", "images/original.jpg");
            CreateProductCard("original", "R15.00", "images/original.jpg");
            CreateProductCard("original", "R15.00", "images/original.jpg");
            CreateProductCard("original", "R15.00", "images/original.jpg");
            CreateProductCard("original", "R15.00", "images/original.jpg");
            CreateProductCard("original", "R15.00", "images/original.jpg");
            CreateProductCard("original", "R15.00", "images/original.jpg");
            CreateProductCard("original", "R15.00", "images/original.jpg");
        }

        private void profile_panel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Pen redPen = new Pen(Color.Red, 5);

            e.Graphics.DrawEllipse(redPen, 2, 2, profile_panel.Width -5, profile_panel.Height-5);    
        }

        private void CreateProductCard(string productName,
                                       string price,
                                       string imagePath)
        {
            // MAIN PANEL
            Panel productPanel = new Panel();
            productPanel.Size = new Size(160, 220);
            productPanel.BackColor = Color.Black;
            productPanel.BorderStyle = BorderStyle.FixedSingle;
            productPanel.Margin = new Padding(10);


            // PRODUCT IMAGE
            PictureBox picture = new PictureBox();
            picture.Size = new Size(140, 100);
            picture.Location = new Point(10, 10);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            if (System.IO.File.Exists(imagePath))
            {
                picture.Image = Image.FromFile(imagePath);
            }


            // PRODUCT NAME
            Label lblName = new Label();
            lblName.Text = productName;
            lblName.ForeColor = Color.White;
            lblName.Font = new Font("Consolas", 11, FontStyle.Bold);
            lblName.AutoSize = true;
            lblName.Location = new Point(10, 120);


            // PRICE LABEL
            Label lblPrice = new Label();
            lblPrice.Text = price;
            lblPrice.ForeColor = Color.Red;
            lblPrice.Font = new Font("Consolas", 11, FontStyle.Bold);
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(10, 150);


            // ADD TO CART BUTTON
            Button btnAdd = new Button();
            btnAdd.Text = "Add To Cart";
            btnAdd.Size = new Size(120, 35);
            btnAdd.Location = new Point(18, 180);
            btnAdd.BackColor = Color.Black;
            btnAdd.ForeColor = Color.Red;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderColor = Color.Red;
            btnAdd.FlatAppearance.BorderSize = 2;


            // BUTTON CLICK EVENT
            btnAdd.Click += (sender, e) =>
            {
                MessageBox.Show(productName + " added to cart!");
            };


            // ADD CONTROLS TO PANEL
            productPanel.Controls.Add(picture);
            productPanel.Controls.Add(lblName);
            productPanel.Controls.Add(lblPrice);
            productPanel.Controls.Add(btnAdd);


            // ADD PANEL TO FLOWLAYOUTPANEL
            all_menu_display.Controls.Add(productPanel);
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void checkout_btn_Click(object sender, EventArgs e)
        {
            Payment_Method payment_Method = new Payment_Method();
            payment_Method.ShowDialog();
        }
    }
}
