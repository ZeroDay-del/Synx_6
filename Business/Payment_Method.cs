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
    public partial class Payment_Method : Form
    {
        public Payment_Method()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cash_button_Click(object sender, EventArgs e)
        {
            Cash_form cash_Form = new Cash_form();
            this.Hide();
            cash_Form.ShowDialog();
        }
    }
}
