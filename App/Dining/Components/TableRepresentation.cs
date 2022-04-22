using SWE3313_JsRestaurant.Data.Entities;
using SWE3313_JsRestaurant.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE3313_JsRestaurant.App.Dining.Components
{
    public partial class TableRepresentation : UserControl
    {
        private TableSeating table;
        private User? waitStaff;
        private User _logginInUser;
        
        public TableRepresentation(TableSeating tableSeating, User user)
        {
            table = tableSeating;
            _logginInUser = user;
            InitializeComponent();
            this.Name = table.GetTableLocation();
            this.tableLabel.Text = table.GetTableLocation();
            waitStaff = table.GetCurrentlyAssignedWaitStaff();
            SetColor();
        }

        public void ViewOrder(object sender, EventArgs e)
        {
            Console.WriteLine("View Order");
            CustomerOrders customerOrders = new();
            customerOrders.Show();
        }

        public void UpdateTableStatus(object sender, EventArgs e)
        {
            Console.WriteLine("Update Table Status");
            switch (table.GetTableStatus())
            {
                case SeatingStatus.Occupied: table.SetDirtyTable(); break;
                case SeatingStatus.Dirty: table.SetCleanTable(); break;
                default: table.SetDirtyTable(); break;
            }
            SetColor();
        }

        public void SetColor()
        {
            if(waitStaff is null || waitStaff != _logginInUser)
            {
                BackColor = Color.LightGray;
                Enabled = false;
                return;
            }

            switch (table.GetTableStatus())
            {
                case SeatingStatus.Occupied: BackColor = Color.LightGoldenrodYellow; break;
                case SeatingStatus.Clean: BackColor = Color.LightGreen; break;
                case SeatingStatus.Dirty: BackColor = Color.LightCoral; break;
                default: BackColor = Color.LightGray; break;
            }
        }

        public void EditOrder()
        {

        }

        private void ViewOptions(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenu = new ();

            contextMenu.Items.Add("Order", null, ViewOrder);
            contextMenu.Items.Add("TableStatus", null, UpdateTableStatus);
            contextMenu.Show(new Point(this.Location.X, this.Location.Y));
        }

    }
}
