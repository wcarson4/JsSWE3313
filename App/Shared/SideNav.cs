using System.ComponentModel;

namespace SWE3313_JsRestaurant.App.Shared;

public partial class SideNav : System.Windows.Forms.Form
{
    public SideNav()
    {
        InitializeComponent();
    }

    public SideNav(IContainer container)
    {
        container.Add(this);

        InitializeComponent();
    }
}