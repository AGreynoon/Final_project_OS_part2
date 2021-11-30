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
    public partial class ProcessManager : Form
    {
        public ProcessManager()
        {
            InitializeComponent();
        }
        private void load()
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                ProcessesListBox.Items.Add(p.ProcessName);
            }
        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ProcessesListBox.Items.Clear();
            load();
        }
        private void KillProcessButton_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            int index = ProcessesListBox.SelectedIndex;
            try
            {
                processes[index].Kill();
                ProcessesListBox.Items.Remove(ProcessesListBox.SelectedItem);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Select a process to be killed, please!");
            }
        }
        private void StartProcessButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(ProcessTextBox.Text);
            }
            catch (Exception e1)
            {
                string message = e1.Message;
                if (message == "The system cannot find the file specified")
                {
                    MessageBox.Show("Wrong process Name!");
                }
            }
        }
        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Form f = new Home();
            f.Show();
            this.Hide();
        }

        private void ProcessManager_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
