using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CAFE101.Business
{
    public partial class ManageMenuItem : Form
    {
        string sourceFile = "";
        string fileName = "";
        string resourcesFolder = "";
        string projectRoot = Directory.GetParent(Application.StartupPath).Parent.FullName;
        string destFile = "";
        public ManageMenuItem()
        {
            InitializeComponent();
            textBox1.TextChanged += textBox1_TextChanged;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            textBox2.TextChanged += textBox2_TextChanged;
        }
    
        private void Form2_Load(object sender, EventArgs e)
        {
            date_label_1.Text = DateTime.Now.ToString("dd/MMM/yyyy HH:mm:ss");
            SetupChart();
            ManageButtons();
        }

        private void ManageButtons()
        {

            if (textBox1.Text.Length != 0 || numericUpDown1.Value != 0 || !comboBox1.Text.ToString().Equals("") || textBox2.Text.Length != 0 || pictureBox2.Image != null)
                button3.Enabled = true;
            else
                button3.Enabled = false;

            if (textBox4.Text.Length != 0 && textBox5.Text.Length != 0 && textBox6.Text.Length != 0 && textBox7.Text.Length != 0 && textBox8.Text.Length != 0 &&
                (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked) &&
                (textBox9.Text.Length != 0 || comboBox2.Text.ToString().Equals("") || numericUpDown2.Value != 0 || textBox11.Text.Length != 0 || pictureBox1.Image != null))
                button6.Enabled = true;
            else
                button6.Enabled = false;

            if (textBox1.Text.Length != 0 && numericUpDown1.Value != 0 && !comboBox1.Text.ToString().Equals("") && textBox2.Text.Length != 0 && pictureBox2.Image != null)
                addButton.Enabled = true;
            else
                addButton.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { ManageButtons(); }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { ManageButtons(); }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { ManageButtons(); }

        private void textBox2_TextChanged(object sender, EventArgs e) { ManageButtons(); }

        private void SetupChart()
        {
            menuItemsChart.Series.Clear();
            menuItemsChart.ChartAreas[0].AxisX.Title = "Menu Item";
            menuItemsChart.ChartAreas[0].AxisY.Title = "Quantity Sold (Current Month)";
            menuItemsChart.ChartAreas[0].AxisX.TitleFont = new Font("Consolas", 10, FontStyle.Bold);
            menuItemsChart.ChartAreas[0].AxisY.TitleFont = new Font("Consolas", 10, FontStyle.Bold);

            Series items = new Series("Sales");
            items.ChartType = SeriesChartType.Bar;
            items.Color = Color.White;

            // Top selling items
            var topItems = new[] { ("Burger", 2500), ("Pizza", 1000), ("Apple", 450) };
            foreach (var (name, quantity) in topItems)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.SetValueY(quantity);
                dataPoint.AxisLabel = name;
                dataPoint.Color = Color.Green;
                items.Points.Add(dataPoint);
            }

            // Lowest selling items
            var lowItems = new[] { ("Banana", 200), ("Plum", 140), ("Egg", 100) };
            foreach (var (name, quantity) in lowItems)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.SetValueY(quantity);
                dataPoint.AxisLabel = name;
                dataPoint.Color = Color.Red;
                items.Points.Add(dataPoint);
            }

            menuItemsChart.Series.Add(items);

            menuItemsChart.ChartAreas[0].AxisY.Maximum = 3000;
            menuItemsChart.ChartAreas[0].AxisY.Minimum = 0;
            menuItemsChart.ChartAreas[0].AxisY.Interval = 250; 
            menuItemsChart.ChartAreas[0].AxisY.LabelStyle.Angle = 90;
            menuItemsChart.ChartAreas[0].AxisX.Interval = 1;
          
            menuItemsChart.Legends[0].CustomItems.Clear();
            LegendItem topItemsLegend = new LegendItem();
            topItemsLegend.Name = "TopItemsLegend";
            topItemsLegend.Color = Color.Green;
            topItemsLegend.ImageStyle = LegendImageStyle.Rectangle;
            topItemsLegend.Name = "Top Selling Item";
            menuItemsChart.Legends[0].CustomItems.Add(topItemsLegend);

            LegendItem lowItemsLegend = new LegendItem();
            lowItemsLegend.Name = "LowLegend";
            lowItemsLegend.Color = Color.Red;
            lowItemsLegend.ImageStyle = LegendImageStyle.Rectangle;
            lowItemsLegend.Name = "Lowest Selling Item";
            menuItemsChart.Legends[0].CustomItems.Add(lowItemsLegend);
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox2.Image = Image.FromFile(open.FileName);
                    label15.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not load image!" + ex.Message);
                }
            }
            sourceFile = open.FileName;
            // fileName = Path.GetFileName(sourceFile);
            fileName = textBox1.Text.ToString() + ".png";
            ManageButtons();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.ToString().Length != 0)
                label5.Visible = false;
            else
                label5.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(open.FileName);
                    label28.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not load image!" + ex.Message);
                }                 
            }
            sourceFile = open.FileName;
            fileName = Path.GetFileName(sourceFile);
            fileName = textBox1.Text.ToString();
            ManageButtons();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text.ToString().Length != 0)
                label25.Visible = false;
            else 
                label25.Visible = true;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text.ToString().Length != 0)
                label31.Visible = false;
            else
                label31.Visible = true;
        }


        //Add button 
        private void button2_Click(object sender, EventArgs e)
        {
            //Add Image into Resource Folder
            resourcesFolder = Path.Combine(projectRoot, "Resources");
            destFile = Path.Combine(resourcesFolder, fileName);
            File.Copy(sourceFile, destFile, overwrite: true);

            ResetAddForm();
        }

        private void ResetAddForm()
        {
            pictureBox2.Image = null;
            textBox1.Text = "";
            comboBox1.SelectedItem = null;
            numericUpDown1.Value = 0;
            textBox2.Text = "";
        }

        private void ResetUpdateForm()
        {
            pictureBox1.Image = null;
            dataGridView1.DataSource = null;
            textBox3.Text = "";
            textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = "";
            groupBox1.Enabled = false;
            textBox9.Text = textBox11.Text = "";
            comboBox2.Text = "";
            numericUpDown2.Value = 0;
            pictureBox1.Image = null;
        }

        //Reset button
        private void button3_Click(object sender, EventArgs e)
        {
            ResetAddForm();
        }

        //Update tab cancel button
        private void button5_Click(object sender, EventArgs e)
        {
            ResetUpdateForm();
        }

        //Add tab Cancel Button
        private void button1_Click(object sender, EventArgs e)
        {
            ResetAddForm();
        }

        //Update tab update button
        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
