using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CAFE101.Business
{
    public partial class SaleReport : Form
    {
        public SaleReport()
        {
            InitializeComponent();
        }

        private void SaleReport_Load(object sender, EventArgs e)
        {
            //Date
            labelDate.Text = DateTime.Now.ToLongDateString();
            comboYear.Items.AddRange(new object[] { 2025, 2026 });
            comboYear.SelectedIndex = 0;
            SetUpSalesChart(2025);


        }
        private void SetUpSalesChart(int year) {

            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Titles.Clear();

            // Chart area with correct Y scale
            ChartArea area = new ChartArea("SalesArea");
            area.AxisY.Minimum = 3000;
            area.AxisY.Maximum = 18000;
            area.AxisY.Interval = 3000;
            area.AxisY.LabelStyle.Format = "R#,##0";
            area.AxisY.Title = "Revenue (ZAR)";
            area.AxisX.Title = "Month";
            area.AxisX.LabelStyle.Angle = 0;
            area.AxisX.Interval = 1;
            area.AxisX.IsLabelAutoFit = false;
            chart1.ChartAreas.Add(area);

            // Empty series with just month labels
            Series series = new Series("Monthly Sales");
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.Red;

            string[] months = { "Jan","Feb","Mar","Apr","May",
                         "Jun","Jul","Aug","Sep","Oct","Nov","Dec" };

            foreach (string month in months)
                series.Points.AddXY(month, 0); // 0 until DB is connected

            chart1.Series.Add(series);
        }

        
        private void comboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = (int)comboYear.SelectedItem;
            SetUpSalesChart(year);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.Show();
            this.Hide();
        }
    }
}
