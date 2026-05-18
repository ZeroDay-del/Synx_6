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
    public partial class IngredientsRestockingReport : Form
    {
        public IngredientsRestockingReport()
        {
            InitializeComponent();
            this.Load += new EventHandler(IngredientsRestockingReport_load);

        }

        private void IngredientsRestockingReport_load(object sender, EventArgs e)
        {
            //introduced try catch block to handle any exceptions that may occur while loading the chart and display an error message to the user if an exception occurs instead of crashing the application
            try
            {
                // Clear existing data points and set up the chart properties for the ingredients restocking report and set the angle of the x-axis labels to 45 degrees
                chart1.Series["Series1"].Points.Clear();
                chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart1.Series["Series1"].Name = "Ingredients Restocking Report";
                chart1.ChartAreas[0].AxisX.Title = "Ingredients";
                chart1.ChartAreas[0].AxisY.Title = "Quantity In Stock";
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 45;

                // Set up the legend and series for the ingredients chart
                chart1.Legends[0].Title = "Key";
                chart1.Series.Add("AboveThreshold");
                chart1.Series["AboveThreshold"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart1.Series["AboveThreshold"].Color = System.Drawing.Color.Green;
                chart1.Series["AboveThreshold"].LegendText = "Above Restock Level";
                chart1.Series["Ingredients Restocking Report"].LegendText = "Below Restock Level";
                chart1.Series["Ingredients Restocking Report"].Color = System.Drawing.Color.Red;

                // Set up the series for the threshold line and add it to the chart to show the restock level on the chart and set the color to red and the width to 1 and the legend text to "Restock Level - " + threshold
                chart1.Series.Add("Threshold");
                int threshold = 30;
                chart1.Series["Threshold"].ChartType = SeriesChartType.Line;
                chart1.Series["Threshold"].Color = System.Drawing.Color.Red;
                chart1.Series["Threshold"].BorderWidth = 1;
                chart1.Series["Threshold"].LegendText = "Restock Level - " + threshold;

                // add data points to the chart using the data from the database using a for each loop to iterate through the data and add the points to the chart
              

                // draw the threshold line on the chart using a for each loop to iterate through the data points and add the threshold value to the chart and set the color of the points to green if they are above the threshold and red if they are below the threshold
                foreach (var point in chart1.Series["Ingredients Restocking Report"].Points)
                {
                    chart1.Series["Threshold"].Points.AddY(threshold);

                    // Set the color of the points based on whether they are above or below the threshold
                    if (point.YValues[0] >= threshold)
                        point.Color = System.Drawing.Color.Green;
                    else
                        point.Color = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart: " + ex.Message);
            }
        }
    }
}
//dummie data 
/*chart1.Series[0].Points.AddXY("Flour", 70);
chart1.Series[0].Points.AddXY("Sugar", 10);
chart1.Series[0].Points.AddXY("Oil", 30);
chart1.Series[0].Points.AddXY("Flour", 40);
chart1.Series[0].Points.AddXY("Sugar", 50);
chart1.Series[0].Points.AddXY("Cooking Oil", 20);
chart1.Series[0].Points.AddXY("Flour", 73);
chart1.Series[0].Points.AddXY("Sugar", 20);
chart1.Series[0].Points.AddXY("Oil", 27); 
*/
