namespace Final_Project_OS
{
    partial class Home
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
            this.ToolsPanel = new System.Windows.Forms.Panel();
            this.APIManagerButton = new System.Windows.Forms.Button();
            this.ProcessesManagerButton = new System.Windows.Forms.Button();
            this.FilesManagerButton = new System.Windows.Forms.Button();
            this.DeviceInformationsGroupBox = new System.Windows.Forms.GroupBox();
            this.HideButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentDirectory = new System.Windows.Forms.Label();
            this.ShowButton = new System.Windows.Forms.Button();
            this.ShowCurrentDirectory = new System.Windows.Forms.Label();
            this.ShowOSArticheture = new System.Windows.Forms.Label();
            this.ShowDeviceName = new System.Windows.Forms.Label();
            this.ShowUserName = new System.Windows.Forms.Label();
            this.ShowOSVersion = new System.Windows.Forms.Label();
            this.OSArticheture = new System.Windows.Forms.Label();
            this.OSVersion = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.DeviceName = new System.Windows.Forms.Label();
            this.ToolsPanel.SuspendLayout();
            this.DeviceInformationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.Controls.Add(this.APIManagerButton);
            this.ToolsPanel.Controls.Add(this.ProcessesManagerButton);
            this.ToolsPanel.Controls.Add(this.FilesManagerButton);
            this.ToolsPanel.Location = new System.Drawing.Point(12, 305);
            this.ToolsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Size = new System.Drawing.Size(637, 151);
            this.ToolsPanel.TabIndex = 0;
            // 
            // APIManagerButton
            // 
            this.APIManagerButton.BackColor = System.Drawing.Color.White;
            this.APIManagerButton.Image = global::Final_Project_OS.Properties.Resources.index;
            this.APIManagerButton.Location = new System.Drawing.Point(425, 48);
            this.APIManagerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.APIManagerButton.Name = "APIManagerButton";
            this.APIManagerButton.Size = new System.Drawing.Size(162, 65);
            this.APIManagerButton.TabIndex = 2;
            this.APIManagerButton.Text = "API";
            this.APIManagerButton.UseVisualStyleBackColor = false;
            this.APIManagerButton.Click += new System.EventHandler(this.APIManagerButton_Click);
            // 
            // ProcessesManagerButton
            // 
            this.ProcessesManagerButton.BackColor = System.Drawing.Color.White;
            this.ProcessesManagerButton.Image = global::Final_Project_OS.Properties.Resources.task_manager_icon_111;
            this.ProcessesManagerButton.Location = new System.Drawing.Point(224, 48);
            this.ProcessesManagerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProcessesManagerButton.Name = "ProcessesManagerButton";
            this.ProcessesManagerButton.Size = new System.Drawing.Size(162, 65);
            this.ProcessesManagerButton.TabIndex = 1;
            this.ProcessesManagerButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProcessesManagerButton.UseVisualStyleBackColor = false;
            this.ProcessesManagerButton.Click += new System.EventHandler(this.ProcessesManagerButton_Click);
            // 
            // FilesManagerButton
            // 
            this.FilesManagerButton.BackColor = System.Drawing.Color.White;
            this.FilesManagerButton.Image = global::Final_Project_OS.Properties.Resources.icons8_file_explorer_50;
            this.FilesManagerButton.Location = new System.Drawing.Point(24, 48);
            this.FilesManagerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilesManagerButton.Name = "FilesManagerButton";
            this.FilesManagerButton.Size = new System.Drawing.Size(162, 65);
            this.FilesManagerButton.TabIndex = 0;
            this.FilesManagerButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FilesManagerButton.UseVisualStyleBackColor = false;
            this.FilesManagerButton.Click += new System.EventHandler(this.FilesManagerButton_Click);
            // 
            // DeviceInformationsGroupBox
            // 
            this.DeviceInformationsGroupBox.BackColor = System.Drawing.Color.Black;
            this.DeviceInformationsGroupBox.Controls.Add(this.HideButton);
            this.DeviceInformationsGroupBox.Controls.Add(this.label1);
            this.DeviceInformationsGroupBox.Controls.Add(this.CurrentDirectory);
            this.DeviceInformationsGroupBox.Controls.Add(this.ShowButton);
            this.DeviceInformationsGroupBox.Controls.Add(this.ShowCurrentDirectory);
            this.DeviceInformationsGroupBox.Controls.Add(this.ShowOSArticheture);
            this.DeviceInformationsGroupBox.Controls.Add(this.ShowDeviceName);
            this.DeviceInformationsGroupBox.Controls.Add(this.ShowUserName);
            this.DeviceInformationsGroupBox.Controls.Add(this.ShowOSVersion);
            this.DeviceInformationsGroupBox.Controls.Add(this.OSArticheture);
            this.DeviceInformationsGroupBox.Controls.Add(this.OSVersion);
            this.DeviceInformationsGroupBox.Controls.Add(this.UserName);
            this.DeviceInformationsGroupBox.Controls.Add(this.DeviceName);
            this.DeviceInformationsGroupBox.ForeColor = System.Drawing.Color.White;
            this.DeviceInformationsGroupBox.Location = new System.Drawing.Point(12, 14);
            this.DeviceInformationsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeviceInformationsGroupBox.Name = "DeviceInformationsGroupBox";
            this.DeviceInformationsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeviceInformationsGroupBox.Size = new System.Drawing.Size(637, 276);
            this.DeviceInformationsGroupBox.TabIndex = 1;
            this.DeviceInformationsGroupBox.TabStop = false;
            this.DeviceInformationsGroupBox.Text = "Device Informations";
            // 
            // HideButton
            // 
            this.HideButton.ForeColor = System.Drawing.Color.Black;
            this.HideButton.Location = new System.Drawing.Point(459, 247);
            this.HideButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(75, 23);
            this.HideButton.TabIndex = 15;
            this.HideButton.Text = "Hide";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "User Name:";
            // 
            // CurrentDirectory
            // 
            this.CurrentDirectory.AutoSize = true;
            this.CurrentDirectory.BackColor = System.Drawing.Color.Black;
            this.CurrentDirectory.ForeColor = System.Drawing.Color.White;
            this.CurrentDirectory.Location = new System.Drawing.Point(17, 186);
            this.CurrentDirectory.Name = "CurrentDirectory";
            this.CurrentDirectory.Size = new System.Drawing.Size(112, 17);
            this.CurrentDirectory.TabIndex = 13;
            this.CurrentDirectory.Text = "CurrentDirectory";
            // 
            // ShowButton
            // 
            this.ShowButton.ForeColor = System.Drawing.Color.Black;
            this.ShowButton.Location = new System.Drawing.Point(549, 247);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 12;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // ShowCurrentDirectory
            // 
            this.ShowCurrentDirectory.AutoSize = true;
            this.ShowCurrentDirectory.BackColor = System.Drawing.Color.Black;
            this.ShowCurrentDirectory.ForeColor = System.Drawing.Color.White;
            this.ShowCurrentDirectory.Location = new System.Drawing.Point(143, 186);
            this.ShowCurrentDirectory.Name = "ShowCurrentDirectory";
            this.ShowCurrentDirectory.Size = new System.Drawing.Size(146, 17);
            this.ShowCurrentDirectory.TabIndex = 10;
            this.ShowCurrentDirectory.Text = "ShowCurrentDirectory";
            this.ShowCurrentDirectory.Visible = false;
            // 
            // ShowOSArticheture
            // 
            this.ShowOSArticheture.AutoSize = true;
            this.ShowOSArticheture.BackColor = System.Drawing.Color.Black;
            this.ShowOSArticheture.ForeColor = System.Drawing.Color.White;
            this.ShowOSArticheture.Location = new System.Drawing.Point(143, 149);
            this.ShowOSArticheture.Name = "ShowOSArticheture";
            this.ShowOSArticheture.Size = new System.Drawing.Size(127, 17);
            this.ShowOSArticheture.TabIndex = 8;
            this.ShowOSArticheture.Text = "ShowOSArticheture";
            this.ShowOSArticheture.Visible = false;
            // 
            // ShowDeviceName
            // 
            this.ShowDeviceName.AutoSize = true;
            this.ShowDeviceName.BackColor = System.Drawing.Color.Black;
            this.ShowDeviceName.ForeColor = System.Drawing.Color.White;
            this.ShowDeviceName.Location = new System.Drawing.Point(143, 37);
            this.ShowDeviceName.Name = "ShowDeviceName";
            this.ShowDeviceName.Size = new System.Drawing.Size(118, 17);
            this.ShowDeviceName.TabIndex = 7;
            this.ShowDeviceName.Text = "ShowDeviceName";
            this.ShowDeviceName.Visible = false;
            // 
            // ShowUserName
            // 
            this.ShowUserName.AutoSize = true;
            this.ShowUserName.BackColor = System.Drawing.Color.Black;
            this.ShowUserName.ForeColor = System.Drawing.Color.White;
            this.ShowUserName.Location = new System.Drawing.Point(143, 71);
            this.ShowUserName.Name = "ShowUserName";
            this.ShowUserName.Size = new System.Drawing.Size(104, 17);
            this.ShowUserName.TabIndex = 6;
            this.ShowUserName.Text = "ShowUserName";
            this.ShowUserName.Visible = false;
            // 
            // ShowOSVersion
            // 
            this.ShowOSVersion.AutoSize = true;
            this.ShowOSVersion.BackColor = System.Drawing.Color.Black;
            this.ShowOSVersion.ForeColor = System.Drawing.Color.White;
            this.ShowOSVersion.Location = new System.Drawing.Point(143, 110);
            this.ShowOSVersion.Name = "ShowOSVersion";
            this.ShowOSVersion.Size = new System.Drawing.Size(104, 17);
            this.ShowOSVersion.TabIndex = 4;
            this.ShowOSVersion.Text = "ShowOSVersion";
            this.ShowOSVersion.Visible = false;
            // 
            // OSArticheture
            // 
            this.OSArticheture.AutoSize = true;
            this.OSArticheture.BackColor = System.Drawing.Color.Black;
            this.OSArticheture.ForeColor = System.Drawing.Color.White;
            this.OSArticheture.Location = new System.Drawing.Point(21, 149);
            this.OSArticheture.Name = "OSArticheture";
            this.OSArticheture.Size = new System.Drawing.Size(101, 17);
            this.OSArticheture.TabIndex = 3;
            this.OSArticheture.Text = "OS articheture:";
            // 
            // OSVersion
            // 
            this.OSVersion.AutoSize = true;
            this.OSVersion.BackColor = System.Drawing.Color.Black;
            this.OSVersion.ForeColor = System.Drawing.Color.White;
            this.OSVersion.Location = new System.Drawing.Point(21, 110);
            this.OSVersion.Name = "OSVersion";
            this.OSVersion.Size = new System.Drawing.Size(79, 17);
            this.OSVersion.TabIndex = 2;
            this.OSVersion.Text = "OS version:";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.Color.Black;
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.Location = new System.Drawing.Point(21, 71);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(0, 17);
            this.UserName.TabIndex = 1;
            // 
            // DeviceName
            // 
            this.DeviceName.AutoSize = true;
            this.DeviceName.BackColor = System.Drawing.Color.Black;
            this.DeviceName.ForeColor = System.Drawing.Color.White;
            this.DeviceName.Location = new System.Drawing.Point(17, 37);
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.Size = new System.Drawing.Size(93, 17);
            this.DeviceName.TabIndex = 0;
            this.DeviceName.Text = "Device Name:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(659, 470);
            this.Controls.Add(this.DeviceInformationsGroupBox);
            this.Controls.Add(this.ToolsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ToolsPanel.ResumeLayout(false);
            this.DeviceInformationsGroupBox.ResumeLayout(false);
            this.DeviceInformationsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ToolsPanel;
        private System.Windows.Forms.Button APIManagerButton;
        private System.Windows.Forms.Button ProcessesManagerButton;
        private System.Windows.Forms.Button FilesManagerButton;
        private System.Windows.Forms.GroupBox DeviceInformationsGroupBox;
        private System.Windows.Forms.Label ShowCurrentDirectory;
        private System.Windows.Forms.Label ShowOSArticheture;
        private System.Windows.Forms.Label ShowDeviceName;
        private System.Windows.Forms.Label ShowUserName;
        private System.Windows.Forms.Label ShowOSVersion;
        private System.Windows.Forms.Label OSArticheture;
        private System.Windows.Forms.Label OSVersion;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label DeviceName;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Label CurrentDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HideButton;
    }
}

