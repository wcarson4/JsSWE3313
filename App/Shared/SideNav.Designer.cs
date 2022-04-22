using System.ComponentModel;

namespace SWE3313_JsRestaurant.App.Shared;

partial class SideNav
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // SideNav
            // 
            this.ClientSize = new System.Drawing.Size(287, 705);
            this.ControlBox = false;
            this.Name = "SideNav";
            this.ResumeLayout(false);

    }

    #endregion
}