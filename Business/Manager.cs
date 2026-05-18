using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFE101.Business
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                "MANAGER DASHBOARD HELP\n\n" +
                "1. View Sale Report\n"+
                "This button opens the Sales Report page where the manager can view the total sales made monthly.\n\n"+

                "2.Manage Employees\n"+
                "This section allows the manager to add new employees, deactivate employee accounts, and update employee roles.\n\n" +

                "3. Manage Menu Items\n" +
                "This section allows the manager to add new menu items, update menu item prices or quantities, and delete menu items.\n\n" +

                "4. Manage Ingredients\n" +
                "This section allows the manager to add ingredients, update ingredient quantities, and delete ingredients from the system.",

                "Cafe101 Manager Help",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaleReport saleReport = new SaleReport();
            saleReport.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageMenuItem manageMenuItem = new ManageMenuItem();
            manageMenuItem.Show();
            this.Hide();
        }
    }
}
