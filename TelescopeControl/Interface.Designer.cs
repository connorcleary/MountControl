namespace TelescopeControl
{
    partial class Interface
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectTelescope = new System.Windows.Forms.Button();
            this.selectedTelescope = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectTelescope
            // 
            this.btnSelectTelescope.Location = new System.Drawing.Point(12, 12);
            this.btnSelectTelescope.Name = "btnSelectTelescope";
            this.btnSelectTelescope.Size = new System.Drawing.Size(109, 25);
            this.btnSelectTelescope.TabIndex = 0;
            this.btnSelectTelescope.Text = "Select Telescope";
            this.btnSelectTelescope.UseVisualStyleBackColor = true;
            this.btnSelectTelescope.UseWaitCursor = true;
            this.btnSelectTelescope.Click += new System.EventHandler(this.btnSelectTelescope_Click);
            // 
            // selectedTelescope
            // 
            this.selectedTelescope.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TelescopeControl.Properties.Settings.Default, "Telescope", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.selectedTelescope.Location = new System.Drawing.Point(127, 15);
            this.selectedTelescope.Name = "selectedTelescope";
            this.selectedTelescope.ReadOnly = true;
            this.selectedTelescope.Size = new System.Drawing.Size(109, 20);
            this.selectedTelescope.TabIndex = 1;
            this.selectedTelescope.Text = global::TelescopeControl.Properties.Settings.Default.Telescope;
            this.selectedTelescope.UseWaitCursor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(242, 13);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(108, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.UseWaitCursor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Interface
            // 
            this.AccessibleDescription = "SelectTelescope";
            this.AccessibleName = "SelectTelescope";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.selectedTelescope);
            this.Controls.Add(this.btnSelectTelescope);
            this.Name = "Interface";
            this.Text = "Telescope Control";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Interface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectTelescope;
        private System.Windows.Forms.TextBox selectedTelescope;
        private System.Windows.Forms.Button btnConnect;
    }
}

