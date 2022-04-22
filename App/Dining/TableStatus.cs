using SWE3313_JsRestaurant.App.Dining.Components;
using SWE3313_JsRestaurant.Data.Entities;
using System.Windows.Forms;

namespace SWE3313_JsRestaurant.App.Dining;

public partial class TableStatus : Form
{
    private List<TableSeating> tables;
    private User _user;
    public TableStatus()
    {
        InitializeComponent();
        Width = Screen.PrimaryScreen.WorkingArea.Width;
        Height = Screen.PrimaryScreen.WorkingArea.Height;
        //_user = new User();
        PopulateTables();
    }

    public TableStatus(User user)
    {
        InitializeComponent();
        Width = Screen.PrimaryScreen.WorkingArea.Width;
        Height = Screen.PrimaryScreen.WorkingArea.Height;
        _user = user;
        PopulateTables();
    }

    private void PopulateTables()
    {
        tables = new List<TableSeating>();
        for (int i = 1; i <= 6; i++)
        {
            TableSeating aTable = new((i, 'A'));
            TableSeating bTable = new((i, 'B'));
            TableSeating cTable = new((i, 'C'));
            TableSeating dTable = new((i, 'D'));
            TableSeating eTable = new((i, 'E'));
            tables.AddRange(new List<TableSeating> { aTable, bTable, cTable, dTable, eTable });
        }

        int offset = 1;

        foreach (var table in tables.OrderBy(tab => tab.GetTableLocation()))
        {
            table.AssignWaitStaff(offset % 5 == 0 ? _user : new User());
            table.SetCleanTable();
            TableRepresentation panel = new(table, _user);
            panel.Name = table.GetTableLocation();
            if (offset <= 6)
            {
                panel.Location = new System.Drawing.Point((this.Size.Width * (offset % 6)) / 6 + 25, 0 * this.Size.Height / 5 + 25);
            }

            if (offset > 6 && offset <= 12)
            {
                panel.Location = new System.Drawing.Point((this.Size.Width * (offset % 6)) / 6 + 25, 1 * this.Size.Height / 5 + 25);
            }

            if (offset > 12 && offset <= 18)
            {
                panel.Location = new System.Drawing.Point((this.Size.Width * (offset % 6)) / 6 + 25, 2 * this.Size.Height / 5 + 25);
            }

            if (offset > 18 && offset <= 24)
            {
                panel.Location = new System.Drawing.Point((this.Size.Width * (offset % 6)) / 6 + 25, 3 * this.Size.Height / 5 + 25);
            }

            if (offset > 24 && offset <= 30)
            {
                panel.Location = new System.Drawing.Point((this.Size.Width * (offset % 6)) / 6 + 25, 4 * this.Size.Height / 5 + 25);
            }

            panel.Width = 50;
            panel.Height = 50;
            //panel.BackColor = Color.Red;
            panel.Visible = true;
            panel.Show();
            panel.BringToFront();
            //panels.Add(panel);
            this.Controls.Add(panel);
            offset++;
        }
    }
}