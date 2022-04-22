using System.ComponentModel;

namespace SWE3313_JsRestaurant.App.Shared;

partial class LoginScreen
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
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.timeClock1 = new SWE3313_JsRestaurant.App.Shared.TimeClock();
            this.success = new System.Windows.Forms.CheckBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNameText
            // 
            this.UserNameText.AcceptsReturn = true;
            this.UserNameText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserNameText.BackColor = System.Drawing.SystemColors.Window;
            this.UserNameText.Location = new System.Drawing.Point(397, 348);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(150, 23);
            this.UserNameText.TabIndex = 0;
            // 
            // PasswordText
            // 
            this.PasswordText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordText.Location = new System.Drawing.Point(397, 418);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(150, 23);
            this.PasswordText.TabIndex = 1;
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.Enabled = false;
            this.success.Location = new System.Drawing.Point(532, 427);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(15, 14);
            this.success.TabIndex = 2;
            this.success.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.Location = new System.Drawing.Point(432, 447);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LoginScreen
            // 
            this.ClientSize = new System.Drawing.Size(983, 569);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.success);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UserNameText);
            this.Name = "LoginScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox UserNameText;
    private TextBox PasswordText;
    private TimeClock timeClock1;
    private CheckBox success;
    private Button loginButton;
}