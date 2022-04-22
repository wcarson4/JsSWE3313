namespace SWE3313_JsRestaurant.App.Dining.Components
{
    partial class TableRepresentation
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.tableLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableLabel
            // 
            this.tableLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLabel.AutoSize = true;
            this.tableLabel.BackColor = System.Drawing.Color.Transparent;
            this.tableLabel.Location = new System.Drawing.Point(15, 16);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(21, 15);
            this.tableLabel.TabIndex = 0;
            this.tableLabel.Text = "A1";
            this.tableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tableLabel.Click += new System.EventHandler(this.ViewOptions);
            // 
            // TableRepresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLabel);
            this.Name = "TableRepresentation";
            this.Size = new System.Drawing.Size(50, 50);
            this.Click += new System.EventHandler(this.ViewOptions);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tableLabel;
    }
}
