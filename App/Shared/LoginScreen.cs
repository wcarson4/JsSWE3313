using System.ComponentModel;

namespace SWE3313_JsRestaurant.App.Shared;

public partial class LoginScreen : Form
{
    public bool IsLoggedIn;
    private bool _success;
    public string userName;

    public LoginScreen()
    {
        InitializeComponent();
    }

    public LoginScreen(IContainer container)
    {
        container.Add(this);

        InitializeComponent();
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        LogIn();
    }

    public void LogIn()
    {
        userName = UserNameText.Text;
        var password = PasswordText.Text;
        
        if(userName == "TEST" && password == "TEST")
        {
            _success = true;
            success.Checked = true;
            IsLoggedIn = true;
            Thread.Sleep(1000);

            this.Close();
            return;
        }
        
        _success = false;
        success.Checked = false;
        IsLoggedIn = false;
        UserNameText.Focus();
        return;
        
        
    }
}