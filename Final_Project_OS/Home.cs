using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Final_Project_OS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            ShowDeviceName.Text = System.Environment.MachineName;
            ShowDeviceName.Visible = true;
            ShowUserName.Text = System.Environment.UserName;
            ShowUserName.Visible = true;
            ShowOSVersion.Text = System.Environment.OSVersion.ToString();
            ShowOSVersion.Visible = true;
            ShowCurrentDirectory.Text = System.Environment.CurrentDirectory;
            ShowCurrentDirectory.Visible = true;
            if (System.Environment.Is64BitOperatingSystem == true)
            {
                ShowOSArticheture.Text = "64 bit";
                ShowOSArticheture.Visible = true;
            }
            else
            {
                ShowOSArticheture.Text = "32 bit";
                ShowOSArticheture.Visible = true;
            }
        }
        private void HideButton_Click(object sender, EventArgs e)
        {
            ShowDeviceName.Text = "";
            ShowDeviceName.Visible = false;
            ShowUserName.Text = "";
            ShowUserName.Visible = false;
            ShowOSVersion.Text = "";
            ShowOSVersion.Visible = false;
            ShowCurrentDirectory.Text = "";
            ShowCurrentDirectory.Visible = false;
            ShowOSArticheture.Text = "";
            ShowOSArticheture.Visible = false;
        }
        private void APIManagerButton_Click(object sender, EventArgs e)
        {
            Form f = new API();
            f.Show();
            this.Hide();
        }
        private void ProcessesManagerButton_Click(object sender, EventArgs e)
        {
            Form f = new ProcessManager();
            f.Show();
            this.Hide();
        }

        private void FilesManagerButton_Click(object sender, EventArgs e)
        {
            Form f = new FilesManager();
            f.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
