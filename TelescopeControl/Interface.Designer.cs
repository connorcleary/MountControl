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
            this.btnSelectData = new System.Windows.Forms.Button();
            this.btnImportData = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbTargetName = new System.Windows.Forms.Label();
            this.lbTargetAos = new System.Windows.Forms.Label();
            this.lbWarning = new System.Windows.Forms.Label();
            this.lbTargetLocked = new System.Windows.Forms.Label();
            this.RunTimer = new System.Windows.Forms.Timer(this.components);
            this.textMinsOffset = new System.Windows.Forms.TextBox();
            this.txtEnterOffset = new System.Windows.Forms.TextBox();
            this.file = new System.Windows.Forms.TextBox();
            this.selectedTelescope = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ImageTimer = new System.Windows.Forms.Timer(this.components);
            this.btnOffset = new System.Windows.Forms.Button();
            this.lbWarningText = new System.Windows.Forms.Label();
            this.btnCheckTelesscope = new System.Windows.Forms.Button();
            this.textRA = new System.Windows.Forms.TextBox();
            this.textDec = new System.Windows.Forms.TextBox();
            this.manualSlew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            // btnSelectData
            // 
            this.btnSelectData.Location = new System.Drawing.Point(12, 43);
            this.btnSelectData.Name = "btnSelectData";
            this.btnSelectData.Size = new System.Drawing.Size(109, 24);
            this.btnSelectData.TabIndex = 3;
            this.btnSelectData.Text = "Select data";
            this.btnSelectData.UseVisualStyleBackColor = true;
            this.btnSelectData.UseWaitCursor = true;
            this.btnSelectData.Click += new System.EventHandler(this.btnSelectData_Click);
            // 
            // btnImportData
            // 
            this.btnImportData.Location = new System.Drawing.Point(242, 43);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(109, 24);
            this.btnImportData.TabIndex = 5;
            this.btnImportData.Text = "Import Data";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.UseWaitCursor = true;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(377, 239);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(63, 13);
            this.lbTime.TabIndex = 6;
            this.lbTime.Text = "Current time";
            this.lbTime.UseWaitCursor = true;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(12, 113);
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
            this.lbTargetName.Location = new System.Drawing.Point(15, 140);
            this.lbTargetName.Name = "lbTargetName";
            this.lbTargetName.Size = new System.Drawing.Size(63, 13);
            this.lbTargetName.TabIndex = 8;
            this.lbTargetName.Text = "target name";
            this.lbTargetName.UseWaitCursor = true;
            // 
            // lbTargetAos
            // 
            this.lbTargetAos.AutoSize = true;
            this.lbTargetAos.Location = new System.Drawing.Point(15, 175);
            this.lbTargetAos.Name = "lbTargetAos";
            this.lbTargetAos.Size = new System.Drawing.Size(57, 13);
            this.lbTargetAos.TabIndex = 9;
            this.lbTargetAos.Text = "next event";
            this.lbTargetAos.UseWaitCursor = true;
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.Location = new System.Drawing.Point(9, 239);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(50, 13);
            this.lbWarning.TabIndex = 10;
            this.lbWarning.Text = "Warning:";
            this.lbWarning.UseWaitCursor = true;
            // 
            // lbTargetLocked
            // 
            this.lbTargetLocked.AutoSize = true;
            this.lbTargetLocked.Location = new System.Drawing.Point(15, 157);
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
            // textMinsOffset
            // 
            this.textMinsOffset.Location = new System.Drawing.Point(135, 81);
            this.textMinsOffset.Name = "textMinsOffset";
            this.textMinsOffset.Size = new System.Drawing.Size(54, 20);
            this.textMinsOffset.TabIndex = 0;
            this.textMinsOffset.UseWaitCursor = true;
            // 
            // txtEnterOffset
            // 
            this.txtEnterOffset.Location = new System.Drawing.Point(53, 81);
            this.txtEnterOffset.Name = "txtEnterOffset";
            this.txtEnterOffset.Size = new System.Drawing.Size(54, 20);
            this.txtEnterOffset.TabIndex = 12;
            this.txtEnterOffset.UseWaitCursor = true;
            // 
            // file
            // 
            this.file.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TelescopeControl.Properties.Settings.Default, "data", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.file.Location = new System.Drawing.Point(127, 45);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Offset:";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "hrs";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "mins";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.UseWaitCursor = true;
            // 
            // ImageTimer
            // 
            this.ImageTimer.Interval = 1000;
            this.ImageTimer.Tick += new System.EventHandler(this.ImageTimer_Tick);
            // 
            // btnOffset
            // 
            this.btnOffset.Location = new System.Drawing.Point(223, 79);
            this.btnOffset.Name = "btnOffset";
            this.btnOffset.Size = new System.Drawing.Size(75, 23);
            this.btnOffset.TabIndex = 16;
            this.btnOffset.Text = "Set";
            this.btnOffset.UseVisualStyleBackColor = true;
            this.btnOffset.UseWaitCursor = true;
            this.btnOffset.Click += new System.EventHandler(this.btnOffset_Click);
            // 
            // lbWarningText
            // 
            this.lbWarningText.AutoSize = true;
            this.lbWarningText.Location = new System.Drawing.Point(65, 239);
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
            // textRA
            // 
            this.textRA.Location = new System.Drawing.Point(232, 148);
            this.textRA.Name = "textRA";
            this.textRA.Size = new System.Drawing.Size(93, 20);
            this.textRA.TabIndex = 19;
            // 
            // textDec
            // 
            this.textDec.Location = new System.Drawing.Point(360, 147);
            this.textDec.Name = "textDec";
            this.textDec.Size = new System.Drawing.Size(93, 20);
            this.textDec.TabIndex = 20;
            // 
            // manualSlew
            // 
            this.manualSlew.Location = new System.Drawing.Point(459, 145);
            this.manualSlew.Name = "manualSlew";
            this.manualSlew.Size = new System.Drawing.Size(75, 23);
            this.manualSlew.TabIndex = 21;
            this.manualSlew.Text = "Slew";
            this.manualSlew.UseVisualStyleBackColor = true;
            this.manualSlew.Click += new System.EventHandler(this.manualSlew_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "RA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Dec";
            // 
            // btnSetOffset
            // 
            this.AcceptButton = this.btnOffset;
            this.AccessibleDescription = "SelectTelescope";
            this.AccessibleName = "SelectTelescope";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.manualSlew);
            this.Controls.Add(this.textDec);
            this.Controls.Add(this.textRA);
            this.Controls.Add(this.btnCheckTelesscope);
            this.Controls.Add(this.lbWarningText);
            this.Controls.Add(this.btnOffset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textMinsOffset);
            this.Controls.Add(this.txtEnterOffset);
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
        private System.Windows.Forms.Button btnSelectData;
        private System.Windows.Forms.TextBox file;
        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbTargetName;
        private System.Windows.Forms.Label lbTargetAos;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Label lbTargetLocked;
        private System.Windows.Forms.Timer RunTimer;
        private System.Windows.Forms.TextBox txtEnterOffset;
        private System.Windows.Forms.TextBox textMinsOffset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer ImageTimer;
        private System.Windows.Forms.Button btnOffset;
        private System.Windows.Forms.Label lbWarningText;
        private System.Windows.Forms.Button btnCheckTelesscope;
        private System.Windows.Forms.TextBox textRA;
        private System.Windows.Forms.TextBox textDec;
        private System.Windows.Forms.Button manualSlew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

