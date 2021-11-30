namespace Final_Project_OS
{
    partial class FilesManager
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
            this.DriversLabel = new System.Windows.Forms.Label();
            this.DeriversComboBox = new System.Windows.Forms.ComboBox();
            this.FilesLabel = new System.Windows.Forms.Label();
            this.SelectedFolderLabel = new System.Windows.Forms.Label();
            this.SelectedFolderTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OperationsComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.StartButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SelectFolderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DriversLabel
            // 
            this.DriversLabel.AutoSize = true;
            this.DriversLabel.BackColor = System.Drawing.Color.Black;
            this.DriversLabel.ForeColor = System.Drawing.Color.White;
            this.DriversLabel.Location = new System.Drawing.Point(42, 21);
            this.DriversLabel.Name = "DriversLabel";
            this.DriversLabel.Size = new System.Drawing.Size(51, 17);
            this.DriversLabel.TabIndex = 0;
            this.DriversLabel.Text = "Drivers";
            // 
            // DeriversComboBox
            // 
            this.DeriversComboBox.BackColor = System.Drawing.Color.Black;
            this.DeriversComboBox.ForeColor = System.Drawing.Color.White;
            this.DeriversComboBox.FormattingEnabled = true;
            this.DeriversComboBox.Location = new System.Drawing.Point(148, 21);
            this.DeriversComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeriversComboBox.Name = "DeriversComboBox";
            this.DeriversComboBox.Size = new System.Drawing.Size(277, 24);
            this.DeriversComboBox.TabIndex = 1;
            this.DeriversComboBox.SelectedIndexChanged += new System.EventHandler(this.DeriversComboBox_SelectedIndexChanged);
            // 
            // FilesLabel
            // 
            this.FilesLabel.AutoSize = true;
            this.FilesLabel.BackColor = System.Drawing.Color.Black;
            this.FilesLabel.ForeColor = System.Drawing.Color.White;
            this.FilesLabel.Location = new System.Drawing.Point(42, 92);
            this.FilesLabel.Name = "FilesLabel";
            this.FilesLabel.Size = new System.Drawing.Size(51, 17);
            this.FilesLabel.TabIndex = 2;
            this.FilesLabel.Text = "Folders";
            // 
            // SelectedFolderLabel
            // 
            this.SelectedFolderLabel.AutoSize = true;
            this.SelectedFolderLabel.BackColor = System.Drawing.Color.Black;
            this.SelectedFolderLabel.ForeColor = System.Drawing.Color.White;
            this.SelectedFolderLabel.Location = new System.Drawing.Point(42, 241);
            this.SelectedFolderLabel.Name = "SelectedFolderLabel";
            this.SelectedFolderLabel.Size = new System.Drawing.Size(100, 17);
            this.SelectedFolderLabel.TabIndex = 4;
            this.SelectedFolderLabel.Text = "Selected Folder";
            // 
            // SelectedFolderTextBox
            // 
            this.SelectedFolderTextBox.BackColor = System.Drawing.Color.Black;
            this.SelectedFolderTextBox.ForeColor = System.Drawing.Color.White;
            this.SelectedFolderTextBox.Location = new System.Drawing.Point(148, 238);
            this.SelectedFolderTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectedFolderTextBox.Name = "SelectedFolderTextBox";
            this.SelectedFolderTextBox.Size = new System.Drawing.Size(277, 24);
            this.SelectedFolderTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Operation";
            // 
            // OperationsComboBox
            // 
            this.OperationsComboBox.BackColor = System.Drawing.Color.Black;
            this.OperationsComboBox.ForeColor = System.Drawing.Color.White;
            this.OperationsComboBox.FormattingEnabled = true;
            this.OperationsComboBox.Items.AddRange(new object[] {
            "Create",
            "Delete",
            "Copy",
            "Cut"});
            this.OperationsComboBox.Location = new System.Drawing.Point(148, 358);
            this.OperationsComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OperationsComboBox.Name = "OperationsComboBox";
            this.OperationsComboBox.Size = new System.Drawing.Size(277, 24);
            this.OperationsComboBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(42, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Destination";
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.BackColor = System.Drawing.Color.Black;
            this.DestinationTextBox.ForeColor = System.Drawing.Color.White;
            this.DestinationTextBox.Location = new System.Drawing.Point(148, 420);
            this.DestinationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(277, 24);
            this.DestinationTextBox.TabIndex = 9;
            // 
            // GoBackButton
            // 
            this.GoBackButton.Image = global::Final_Project_OS.Properties.Resources.index1;
            this.GoBackButton.Location = new System.Drawing.Point(33, 472);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(75, 47);
            this.GoBackButton.TabIndex = 14;
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Black;
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(148, 92);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(277, 118);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(148, 472);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(118, 47);
            this.StartButton.TabIndex = 11;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(307, 472);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(118, 47);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click_1);
            // 
            // PathTextBox
            // 
            this.PathTextBox.BackColor = System.Drawing.Color.Black;
            this.PathTextBox.ForeColor = System.Drawing.Color.White;
            this.PathTextBox.Location = new System.Drawing.Point(148, 301);
            this.PathTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(277, 24);
            this.PathTextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "path";
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(458, 298);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(96, 23);
            this.SelectFileButton.TabIndex = 19;
            this.SelectFileButton.Text = "Select file";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SelectFolderButton
            // 
            this.SelectFolderButton.Location = new System.Drawing.Point(458, 420);
            this.SelectFolderButton.Name = "SelectFolderButton";
            this.SelectFolderButton.Size = new System.Drawing.Size(96, 23);
            this.SelectFolderButton.TabIndex = 20;
            this.SelectFolderButton.Text = "Select folder";
            this.SelectFolderButton.UseVisualStyleBackColor = true;
            this.SelectFolderButton.Click += new System.EventHandler(this.SelectFolderButton_Click);
            // 
            // FilesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(659, 530);
            this.Controls.Add(this.SelectFolderButton);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.DestinationTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OperationsComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SelectedFolderTextBox);
            this.Controls.Add(this.SelectedFolderLabel);
            this.Controls.Add(this.FilesLabel);
            this.Controls.Add(this.DeriversComboBox);
            this.Controls.Add(this.DriversLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FilesManager";
            this.Text = "FilesManager";
            this.Load += new System.EventHandler(this.FilesManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DriversLabel;
        private System.Windows.Forms.ComboBox DeriversComboBox;
        private System.Windows.Forms.Label FilesLabel;
        private System.Windows.Forms.Label SelectedFolderLabel;
        private System.Windows.Forms.TextBox SelectedFolderTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox OperationsComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SelectFolderButton;
    }
}