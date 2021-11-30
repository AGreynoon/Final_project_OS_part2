namespace Final_Project_OS
{
    partial class ProcessManager
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
            this.ProcessesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KillProcessButton = new System.Windows.Forms.Button();
            this.StartProcessButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.ProcessTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProcessesListBox
            // 
            this.ProcessesListBox.BackColor = System.Drawing.Color.Black;
            this.ProcessesListBox.ForeColor = System.Drawing.Color.White;
            this.ProcessesListBox.FormattingEnabled = true;
            this.ProcessesListBox.ItemHeight = 16;
            this.ProcessesListBox.Location = new System.Drawing.Point(12, 71);
            this.ProcessesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProcessesListBox.Name = "ProcessesListBox";
            this.ProcessesListBox.Size = new System.Drawing.Size(623, 308);
            this.ProcessesListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Process For Kill";
            // 
            // KillProcessButton
            // 
            this.KillProcessButton.Location = new System.Drawing.Point(167, 400);
            this.KillProcessButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KillProcessButton.Name = "KillProcessButton";
            this.KillProcessButton.Size = new System.Drawing.Size(120, 52);
            this.KillProcessButton.TabIndex = 2;
            this.KillProcessButton.Text = "Kill prosess";
            this.KillProcessButton.UseVisualStyleBackColor = true;
            this.KillProcessButton.Click += new System.EventHandler(this.KillProcessButton_Click);
            // 
            // StartProcessButton
            // 
            this.StartProcessButton.Location = new System.Drawing.Point(325, 400);
            this.StartProcessButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartProcessButton.Name = "StartProcessButton";
            this.StartProcessButton.Size = new System.Drawing.Size(120, 52);
            this.StartProcessButton.TabIndex = 3;
            this.StartProcessButton.Text = "Start Process";
            this.StartProcessButton.UseVisualStyleBackColor = true;
            this.StartProcessButton.Click += new System.EventHandler(this.StartProcessButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(561, 386);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Text = "refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Image = global::Final_Project_OS.Properties.Resources.index1;
            this.GoBackButton.Location = new System.Drawing.Point(24, 400);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(92, 52);
            this.GoBackButton.TabIndex = 5;
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // ProcessTextBox
            // 
            this.ProcessTextBox.BackColor = System.Drawing.Color.Black;
            this.ProcessTextBox.ForeColor = System.Drawing.Color.White;
            this.ProcessTextBox.Location = new System.Drawing.Point(11, 25);
            this.ProcessTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProcessTextBox.Name = "ProcessTextBox";
            this.ProcessTextBox.Size = new System.Drawing.Size(624, 24);
            this.ProcessTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Write Process for Start";
            // 
            // ProcessManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(659, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProcessTextBox);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.StartProcessButton);
            this.Controls.Add(this.KillProcessButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcessesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ProcessManager";
            this.Text = "ProcessManager";
            this.Load += new System.EventHandler(this.ProcessManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProcessesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button KillProcessButton;
        private System.Windows.Forms.Button StartProcessButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.TextBox ProcessTextBox;
        private System.Windows.Forms.Label label2;
    }
}