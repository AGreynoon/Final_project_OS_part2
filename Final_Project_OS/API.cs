using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Final_Project_OS
{
    public partial class API : Form
    {
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
        public API()
        {
            InitializeComponent();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 0");
        }

        private void PowerOffButton_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }

        private void ForceLogOutButton_Click(object sender, EventArgs e)
        {
            ExitWindowsEx(4, 0);
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            ExitWindowsEx(0, 0);
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Form f = new Home();
            f.Show();
            this.Hide();
        }
    }
}
