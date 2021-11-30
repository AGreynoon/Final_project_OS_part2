namespace Final_Project_OS
{
    partial class API
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
            this.PowerOffButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.ForceLogOutButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PowerOffButton
            // 
            this.PowerOffButton.Location = new System.Drawing.Point(341, 126);
            this.PowerOffButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PowerOffButton.Name = "PowerOffButton";
            this.PowerOffButton.Size = new System.Drawing.Size(94, 47);
            this.PowerOffButton.TabIndex = 0;
            this.PowerOffButton.Text = "Power off";
            this.PowerOffButton.UseVisualStyleBackColor = true;
            this.PowerOffButton.Click += new System.EventHandler(this.PowerOffButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(176, 126);
            this.RestartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(94, 47);
            this.RestartButton.TabIndex = 1;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(341, 219);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(94, 47);
            this.LogOutButton.TabIndex = 2;
            this.LogOutButton.Text = "Log-out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // ForceLogOutButton
            // 
            this.ForceLogOutButton.Location = new System.Drawing.Point(176, 219);
            this.ForceLogOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ForceLogOutButton.Name = "ForceLogOutButton";
            this.ForceLogOutButton.Size = new System.Drawing.Size(94, 47);
            this.ForceLogOutButton.TabIndex = 3;
            this.ForceLogOutButton.Text = "Force Log-out";
            this.ForceLogOutButton.UseVisualStyleBackColor = true;
            this.ForceLogOutButton.Click += new System.EventHandler(this.ForceLogOutButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Image = global::Final_Project_OS.Properties.Resources.index1;
            this.GoBackButton.Location = new System.Drawing.Point(27, 391);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(93, 66);
            this.GoBackButton.TabIndex = 4;
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // API
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(659, 470);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.ForceLogOutButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.PowerOffButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "API";
            this.Text = "API";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PowerOffButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button ForceLogOutButton;
        private System.Windows.Forms.Button GoBackButton;
    }
}