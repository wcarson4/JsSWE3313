using Microsoft.VisualBasic.ApplicationServices;
using SWE3313_JsRestaurant.App.Dining;
using SWE3313_JsRestaurant.App.Shared;
using SWE3313_JsRestaurant.Data.Entities;
using User = SWE3313_JsRestaurant.Data.Entities.User;

namespace SWE3313_JsRestaurant.App;

public partial class MainForm : Form
{
    public bool _loggedIn;
    private LoginScreen loginScreen = new LoginScreen();
    private User _user;
    private Role _role;
    public MainForm()
    {
        InitializeComponent();
        var loggedIn = Login();
        WindowState = FormWindowState.Maximized;
        Enabled = true;
        

        TableStatus tableStatus = new(_user);
        
        IsMdiContainer = true;
        tableStatus.MdiParent = this;
        tableStatus.WindowState = FormWindowState.Maximized;
        tableStatus.Show();
        
    }

    private bool Login()
    {
        loginScreen.ShowDialog();
        loginScreen.Focus();
        loginScreen.BringToFront();
        return loginScreen.IsLoggedIn;
    }

    private void SetData(object sender, FormClosingEventArgs e)
    {
        _user = new User
        {
            UserName = loginScreen.userName
        };
    }

    private void IsEnabled()
    {
        if (_loggedIn)
            this.Enabled = true;
        this.Enabled = false;
    }
}