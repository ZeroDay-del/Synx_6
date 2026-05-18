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
    public enum OrderStatus // so each block can change at different times, with respective to the column that it is on.
    {
        New,
        Preparing,
        Ready,
        Completed,
        Held
    }

    public partial class kitchenScreen : Form
    {
        private FlowLayoutPanel pnlNewOrders;
        private FlowLayoutPanel pnlPreparing;
        private FlowLayoutPanel pnlReady;
        private FlowLayoutPanel pnlCompleted;
        private FlowLayoutPanel pnlHeld;

        //private Timer clockTimer;

        // Dummy variables //
        private int orderIncremeter = 1;
        private int allOrderCounter = 0;
        private int inProgress = 0;

        public kitchenScreen()
        {
            InitializeComponent();
            allOrderCounterText.Text = allOrderCounter.ToString();

            // I need this window to display as a full kitchcen screen
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None; // I am removing all of the border components around the screen 

            pictureBox1.Image = Properties.Resources.order_now;
            pictureBox3.Image = Properties.Resources.processing_time;
            pictureBox4.Image = Properties.Resources.barbecue;
            pictureBox5.Image = Properties.Resources.deep_fryer;
            pictureBox6.Image = Properties.Resources.soft_drink;
            label15.Text = DateTime.Now.ToString("HH:mm:ss");

            theMainDisplayIU();
            LoadOrders();
            





        }

        private void theMainDisplayIU()
        {

            TableLayoutPanel table = new TableLayoutPanel();

            // CHANGED SECTION
            table.Dock = DockStyle.None;

            table.Location = new Point(0, panel1.Height); // The main display should begin to be displayed underneath the topbar

            table.Size = new Size( // This is how wide and high this main display should be //
                this.ClientSize.Width,
                this.ClientSize.Height - panel1.Height
            );


            // I have to Keep the table attached to all 4 sides of the form.
            table.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            
            // Let us create the table
            table.ColumnCount = 5;
            table.RowCount = 1;
            table.BackColor = Color.FromArgb(20, 20, 20);

            for (int i = 0; i < 5; i++)
            {
                table.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Percent, 20)
                );
            }

            this.Controls.Add(table);

            //Let us have our columns added into the above table, 
            // so i can added these cards into the respective columns when needed
            pnlNewOrders = CreateColumn(
                table,
                0,
                "NEW ORDERS",
                Color.RoyalBlue
            );

            pnlPreparing = CreateColumn(
                table,
                1,
                "PREPARING",
                Color.DarkOrange
            );

            pnlReady = CreateColumn(
                table,
                2,
                "READY",
                Color.Green
            );

            pnlCompleted = CreateColumn(
                table,
                3,
                "COMPLETED",
                Color.Gray
            );

            pnlHeld = CreateColumn(
                table,
                4,
                "HELD",
                Color.Purple
            );
        }
        // the below are the definition of each and every card that is added into the table

        private FlowLayoutPanel CreateColumn( // each and avery column has the definition from the below, as it returns a FlowLayoutPanel
            TableLayoutPanel parent, // this is the main table will be holding all of the columns 
            int columnIndex, // the column number
            string title, // this is the name of the column
            Color headerColor) // so that each column can have different colours
        {
            // This will be the main container

            Panel container = new Panel(); // thsi will act as a full column container
            container.Dock = DockStyle.Fill; // should fill the entire column cell
            container.Margin = new Padding(3); // this will then add some spacing around the column

            // This is the header section, that will deal with the top section

            Panel header = new Panel();
            header.Dock = DockStyle.Top; // places the header at the top of the container //
            header.Height = 40;
            header.BackColor = headerColor; 

            container.Controls.Add(header);


            // this is the header label //

            Label lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(10, 10);

            header.Controls.Add(lblTitle); 

            //this deals with the flow control, since we need the flowlayoutpanel //
            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Dock = DockStyle.Fill; // makes order area fill remaining space.
            flow.AutoScroll = true; // i have to make this scrollable incase there are many orders that are being made //
            flow.WrapContents = false;
            flow.FlowDirection = FlowDirection.TopDown; // I should be scolling from top down
            flow.BackColor = Color.FromArgb(25, 25, 25);

            flow.Padding = new Padding(0, 25, 0, 0);

            container.Controls.Add(flow);
            // then add this to the table //
            

            parent.Controls.Add(container, columnIndex, 0); // this will place the column container into the table, into a specific position.. I have to adjust the 0, since it specifies the row

            return flow;
        }

        //-----------------creation of the order card----------------------------//

        private Panel CreateOrderCard(
            string orderID,
            int amount,
            string items,
            Color accentColor,
            OrderStatus status
            )
        {
            // the Card panel
            // when a new card is created, i have to check if the status is a new order then
            // increment the static counter 
            
            if (status == OrderStatus.New)
            {
                allOrderCounter++;
                allOrderCounterText.Text = allOrderCounter.ToString();
            }
            else if (status == OrderStatus.Preparing)
            {
                inProgress++;
                progressText.Text = inProgress.ToString();
            }
            

            Panel card = new Panel();
            card.Width = 300;
            card.Height = 260;
            card.BackColor = Color.FromArgb(35, 35, 35);
            card.BorderStyle = BorderStyle.FixedSingle; 
            card.Margin = new Padding(10);

            // The orderID label //

            Label lblOrderID = new Label();
            lblOrderID.Text = orderID;
            lblOrderID.ForeColor = accentColor;
            lblOrderID.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblOrderID.AutoSize = true;
            lblOrderID.Location = new Point(10, 10);

            card.Controls.Add(lblOrderID);

            

           // The Quantity label //

            Label lblQuantity = new Label();
            lblQuantity.Text = "Quantity: " + amount.ToString();
            lblQuantity.ForeColor = Color.LightGray;
            lblQuantity.Font = new Font("Segoe UI", 10);
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(10, 85);

            card.Controls.Add(lblQuantity);

            // the items textbox //
            
            TextBox txtItems = new TextBox();
            txtItems.Multiline = true;
            txtItems.ReadOnly = true;
            txtItems.BorderStyle = BorderStyle.None;
            txtItems.BackColor = Color.FromArgb(45, 45, 45);
            txtItems.ForeColor = Color.White;
            txtItems.Font = new Font("Segoe UI", 11);

            txtItems.Text =
                items;

            txtItems.Location = new Point(10, 120);
            txtItems.Width = 260;
            txtItems.Height = 70;

            card.Controls.Add(txtItems);

            // the timer label
            

            Label lblTimer = new Label();
            lblTimer.Text = "02:15";
            lblTimer.ForeColor = Color.Gold;
            lblTimer.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(220, 15);

            card.Controls.Add(lblTimer);

            
            // this is the action button below the cards
            

            Button btnAction = new Button();
            btnAction.Text = "MOVE ORDER";
            btnAction.Width = 250;
            btnAction.Height = 40;

            btnAction.BackColor = accentColor;
            btnAction.ForeColor = Color.White;

            btnAction.FlatStyle = FlatStyle.Flat;

            btnAction.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            btnAction.Location = new Point(20, 205);

            card.Controls.Add(btnAction);

            btnAction.Click += (s, e) => // this action event will then be responsible for each order block to move column by column
            {
                if (status == OrderStatus.New)
                {
                    pnlNewOrders.Controls.Remove(card);
                    pnlPreparing.Controls.Add(card);
                    status = OrderStatus.New;
                }else if (status == OrderStatus.Preparing)
                {
                    pnlPreparing.Controls.Remove(card);
                    pnlReady.Controls.Add(card);
                    status = OrderStatus.Ready;
                }else if (status == OrderStatus.Ready)
                {
                    pnlReady.Controls.Remove(card);
                    pnlCompleted.Controls.Add(card);
                    status = OrderStatus.Completed;
                }
                
            };

            return card;
        }

        
        // the load sample order
        

        private void LoadOrders()
        {

            // the new order

            Panel order1 = CreateOrderCard(
                "#1058",
                orderIncremeter++,
                "2 Burgers\r\n1 Fries\r\n2 Coke",
                Color.RoyalBlue,
                OrderStatus.New
            );
            pnlNewOrders.Controls.Add(order1);

            
            // the preparation
            

            Panel order2 = CreateOrderCard(
                "#1057",
                orderIncremeter++,
                "1 BBQ Burger\r\n1 Onion Rings\r\n1 Tea",
                Color.DarkOrange,
                OrderStatus.Preparing
            );

            pnlPreparing.Controls.Add(order2);

            
            // the ready order
            

            Panel order3 = CreateOrderCard(
                "#1054",
                orderIncremeter++,
                "1 Pizza\r\n1 Garlic Bread",
                Color.Green,
                OrderStatus.Ready
            );

            pnlReady.Controls.Add(order3);

            
            // the completed order
         

            Panel order4 = CreateOrderCard(
                "#1050",
                orderIncremeter++,
                "1 Pasta\r\n1 Coke",
                Color.Gray,
                OrderStatus.Completed
            );

            pnlCompleted.Controls.Add(order4);

            
            // this is the held order

            Panel order5 = CreateOrderCard(
                "#1048",
                orderIncremeter++,
                "2 Chicken Wraps",
                Color.Purple,
                OrderStatus.Held
            );

            // I then need to create more orders here //

            pnlHeld.Controls.Add(order5);


            Panel order6 = CreateOrderCard(
                "#1111",
                orderIncremeter++,
                "kota",
                Color.Purple,
                OrderStatus.New
            );

            pnlNewOrders.Controls.Add(order6);

            Panel order7 = CreateOrderCard(
                "#1111",
                orderIncremeter++,
                "kota",
                Color.Purple,
                OrderStatus.New
            );
            pnlNewOrders.Controls.Add(order7);
        }

        

        private void kitchenScreen_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.LightBlue, 3))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    0,
                    0,
                    panel4.Width - 1,
                    panel4.Height - 1);
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void addNewOrder(string orderID, string items)
        {
            Panel newOrder = CreateOrderCard(
                orderID,
                orderIncremeter++, // in this place, this is where there will be a new ID given
                items,
                Color.Purple,
                OrderStatus.New
                );
            pnlNewOrders.Controls.Add(newOrder);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
