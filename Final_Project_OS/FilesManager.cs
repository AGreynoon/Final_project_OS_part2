using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final_Project_OS
{
    public partial class FilesManager : Form
    {
        public FilesManager()
        {
            InitializeComponent();
        }
        DriveInfo[] allDrives = DriveInfo.GetDrives();
        public void Create()
        {
            try
            {
                string sourcefile = PathTextBox.Text;
                if (File.Exists(sourcefile))
                {
                    MessageBox.Show("file name is found");
                }
                else
                {
                    File.Create(sourcefile);
                    MessageBox.Show("the file create successfuly");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Copy()
        {
            try
            {
                string sourcefile = PathTextBox.Text;
                string desfile = DestinationTextBox.Text;
                if (!File.Exists(sourcefile))
                {
                    MessageBox.Show("file not found");
                }
                else
                {
                    File.Copy(sourcefile, desfile);
                    MessageBox.Show("the file copied successfuly");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Cut()
        {
            try
            {
                string sourcefile = PathTextBox.Text;
                string desfile = DestinationTextBox.Text;
                if (!File.Exists(sourcefile))
                {
                    MessageBox.Show("file not found");
                }
                else
                {
                    File.Move(sourcefile, desfile);
                    MessageBox.Show("the file Cuted successfuly");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Delete()
        {
            try
            {
                string sourcefile = PathTextBox.Text;
                string desfile = DestinationTextBox.Text;
                if (!File.Exists(sourcefile))
                {
                    MessageBox.Show("file not found");
                }
                else
                {
                    File.Delete(sourcefile);
                    MessageBox.Show("the file Cuted successfuly");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loadDrivers()
        {
            DeriversComboBox.Items.Clear();
            DeriversComboBox.Select();
            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady == true)
                {
                    DeriversComboBox.Items.Add(d.RootDirectory.ToString());
                }
            }
        }
        private void load()
        {
            listView1.Items.Clear();
            string[] fileArray = Directory.GetDirectories(DeriversComboBox.SelectedItem.ToString());
            for (int i = 0; i < fileArray.Length; i++)
            {
                listView1.Items.Add(fileArray[i]);
            }
        }
        private void DeriversComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            load();
        }
        private void FilesManager_Load(object sender, EventArgs e)
        {
            loadDrivers();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedFolderTextBox.Text = listView1.SelectedItems[0].Text;
            load();
        }
        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Form f = new Home();
            f.Show();
            this.Hide();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (OperationsComboBox.SelectedItem == "Create")
            {
                Create();
            }
            else if (OperationsComboBox.SelectedItem == "Copy")
            {
                Copy();
            }
            else if (OperationsComboBox.SelectedItem == "Cut")
            {
                Cut();
            }
            else if (OperationsComboBox.SelectedItem == "Delete")
            {
                Delete();
            }
        }
        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            DeriversComboBox.Text = "";
            listView1.Clear();
            SelectedFolderTextBox.Text = "";
            OperationsComboBox.Text = "";
            DestinationTextBox.Text = "";
            PathTextBox.Text = "";
        }
        private void SelectFileButton_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.InitialDirectory = SelectedFolderTextBox.Text;
            PathTextBox.Text = openFileDialog1.FileName;
        }

        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            DestinationTextBox.Text = openFileDialog1.FileName;
        }
    }
}
