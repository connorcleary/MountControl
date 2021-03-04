namespace TelescopeControl
{
    partial class btnSetOffset
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
            this.components = new System.ComponentModel.Container();
            this.btnSelectTelescope = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnImportData = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbTargetName = new System.Windows.Forms.Label();
            this.lbTargetAos = new System.Windows.Forms.Label();
            this.lbWarning = new System.Windows.Forms.Label();
            this.lbTargetLocked = new System.Windows.Forms.Label();
            this.RunTimer = new System.Windows.Forms.Timer(this.components);
            this.file = new System.Windows.Forms.TextBox();
            this.selectedTelescope = new System.Windows.Forms.TextBox();
            this.ImageTimer = new System.Windows.Forms.Timer(this.components);
            this.lbWarningText = new System.Windows.Forms.Label();
            this.btnCheckTelesscope = new System.Windows.Forms.Button();
            this.btnSelectData = new System.Windows.Forms.Button();
            this.btnSetExposure = new System.Windows.Forms.Button();
            this.tbExposure = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSelectTelescope
            // 
            this.btnSelectTelescope.Location = new System.Drawing.Point(12, 12);
            this.btnSelectTelescope.Name = "btnSelectTelescope";
            this.btnSelectTelescope.Size = new System.Drawing.Size(109, 25);
            this.btnSelectTelescope.TabIndex = 0;
            this.btnSelectTelescope.Text = "Select mount";
            this.btnSelectTelescope.UseVisualStyleBackColor = true;
            this.btnSelectTelescope.UseWaitCursor = true;
            this.btnSelectTelescope.Click += new System.EventHandler(this.btnSelectTelescope_Click);
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
            // btnImportData
            // 
            this.btnImportData.Location = new System.Drawing.Point(241, 42);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(109, 24);
            this.btnImportData.TabIndex = 5;
            this.btnImportData.Text = "Import";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.UseWaitCursor = true;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(381, 205);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(66, 13);
            this.lbTime.TabIndex = 6;
            this.lbTime.Text = "Current time:";
            this.lbTime.UseWaitCursor = true;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(12, 103);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 24);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start tracking";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbTargetName
            // 
            this.lbTargetName.AutoSize = true;
            this.lbTargetName.Location = new System.Drawing.Point(9, 130);
            this.lbTargetName.Name = "lbTargetName";
            this.lbTargetName.Size = new System.Drawing.Size(63, 13);
            this.lbTargetName.TabIndex = 8;
            this.lbTargetName.Text = "target name";
            this.lbTargetName.UseWaitCursor = true;
            // 
            // lbTargetAos
            // 
            this.lbTargetAos.AutoSize = true;
            this.lbTargetAos.Location = new System.Drawing.Point(9, 169);
            this.lbTargetAos.Name = "lbTargetAos";
            this.lbTargetAos.Size = new System.Drawing.Size(57, 13);
            this.lbTargetAos.TabIndex = 9;
            this.lbTargetAos.Text = "next event";
            this.lbTargetAos.UseWaitCursor = true;
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.Location = new System.Drawing.Point(9, 205);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(50, 13);
            this.lbWarning.TabIndex = 10;
            this.lbWarning.Text = "Warning:";
            this.lbWarning.UseWaitCursor = true;
            // 
            // lbTargetLocked
            // 
            this.lbTargetLocked.AutoSize = true;
            this.lbTargetLocked.Location = new System.Drawing.Point(9, 150);
            this.lbTargetLocked.Name = "lbTargetLocked";
            this.lbTargetLocked.Size = new System.Drawing.Size(65, 13);
            this.lbTargetLocked.TabIndex = 11;
            this.lbTargetLocked.Text = "target status";
            this.lbTargetLocked.UseWaitCursor = true;
            // 
            // RunTimer
            // 
            this.RunTimer.Interval = 500;
            this.RunTimer.Tick += new System.EventHandler(this.RunTimer_Tick);
            // 
            // file
            // 
            this.file.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TelescopeControl.Properties.Settings.Default, "data", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.file.Location = new System.Drawing.Point(127, 43);
            this.file.Name = "file";
            this.file.ReadOnly = true;
            this.file.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.file.Size = new System.Drawing.Size(109, 20);
            this.file.TabIndex = 4;
            this.file.Text = global::TelescopeControl.Properties.Settings.Default.data;
            this.file.UseWaitCursor = true;
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
            // ImageTimer
            // 
            this.ImageTimer.Interval = 1000;
            this.ImageTimer.Tick += new System.EventHandler(this.ImageTimer_Tick);
            // 
            // lbWarningText
            // 
            this.lbWarningText.AutoSize = true;
            this.lbWarningText.Location = new System.Drawing.Point(65, 205);
            this.lbWarningText.Name = "lbWarningText";
            this.lbWarningText.Size = new System.Drawing.Size(0, 13);
            this.lbWarningText.TabIndex = 17;
            this.lbWarningText.UseWaitCursor = true;
            // 
            // btnCheckTelesscope
            // 
            this.btnCheckTelesscope.Enabled = false;
            this.btnCheckTelesscope.Location = new System.Drawing.Point(355, 13);
            this.btnCheckTelesscope.Name = "btnCheckTelesscope";
            this.btnCheckTelesscope.Size = new System.Drawing.Size(108, 23);
            this.btnCheckTelesscope.TabIndex = 18;
            this.btnCheckTelesscope.Text = "Test";
            this.btnCheckTelesscope.UseVisualStyleBackColor = true;
            this.btnCheckTelesscope.Click += new System.EventHandler(this.btnCheckTelesscope_Click);
            // 
            // btnSelectData
            // 
            this.btnSelectData.Location = new System.Drawing.Point(12, 43);
            this.btnSelectData.Name = "btnSelectData";
            this.btnSelectData.Size = new System.Drawing.Size(109, 24);
            this.btnSelectData.TabIndex = 3;
            this.btnSelectData.Text = "Select schedule";
            this.btnSelectData.UseVisualStyleBackColor = true;
            this.btnSelectData.UseWaitCursor = true;
            this.btnSelectData.Click += new System.EventHandler(this.btnSelectData_Click);
            // 
            // btnSetExposure
            // 
            this.btnSetExposure.Location = new System.Drawing.Point(12, 73);
            this.btnSetExposure.Name = "btnSetExposure";
            this.btnSetExposure.Size = new System.Drawing.Size(109, 24);
            this.btnSetExposure.TabIndex = 19;
            this.btnSetExposure.Text = "Choose exposure";
            this.btnSetExposure.UseVisualStyleBackColor = true;
            this.btnSetExposure.UseWaitCursor = true;
            this.btnSetExposure.Click += new System.EventHandler(this.btnSetExposure_Click);
            // 
            // tbExposure
            // 
            this.tbExposure.Location = new System.Drawing.Point(127, 73);
            this.tbExposure.Name = "tbExposure";
            this.tbExposure.Size = new System.Drawing.Size(109, 20);
            this.tbExposure.TabIndex = 20;
            this.tbExposure.Text = "10";
            this.tbExposure.UseWaitCursor = true;
            // 
            // btnSetOffset
            // 
            this.AccessibleDescription = "SelectTelescope";
            this.AccessibleName = "SelectTelescope";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 227);
            this.Controls.Add(this.tbExposure);
            this.Controls.Add(this.btnSetExposure);
            this.Controls.Add(this.btnCheckTelesscope);
            this.Controls.Add(this.lbWarningText);
            this.Controls.Add(this.lbTargetLocked);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.lbTargetAos);
            this.Controls.Add(this.lbTargetName);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.btnImportData);
            this.Controls.Add(this.file);
            this.Controls.Add(this.btnSelectData);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.selectedTelescope);
            this.Controls.Add(this.btnSelectTelescope);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "btnSetOffset";
            this.Text = "Set ";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectTelescope;
        private System.Windows.Forms.TextBox selectedTelescope;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox file;
        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbTargetName;
        private System.Windows.Forms.Label lbTargetAos;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Label lbTargetLocked;
        private System.Windows.Forms.Timer RunTimer;
        private System.Windows.Forms.Timer ImageTimer;
        private System.Windows.Forms.Label lbWarningText;
        private System.Windows.Forms.Button btnCheckTelesscope;
        private System.Windows.Forms.Button btnSelectData;
        private System.Windows.Forms.Button btnSetExposure;
        private System.Windows.Forms.TextBox tbExposure;
    }
}

