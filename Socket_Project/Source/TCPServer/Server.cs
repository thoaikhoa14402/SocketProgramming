using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using TCP_Server;

namespace TCPServer
{
    public partial class TCPServer : Form
    {
        public TCPServer()
        {
            InitializeComponent();
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: TCPSever\t\t\t\t\n\nAuthor: KV_IT\t\t\n\nVersion: 1.0.1\t\t\n\nDate: 1/7/2021", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TCPSever_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes) e.Cancel = false; // cancel = false ==> khong huy su kien dang dien ra
            else e.Cancel = true; // ==> huy su dien dang dien ra
        }

        private void Automatic_CheckedChanged(object sender, EventArgs e)
        {
            if (Automatic.Checked == false)
            {
                IPaddr.Text = "";
                Port_num.Text = "";
                IPaddr.ReadOnly = false;
                Port_num.ReadOnly = false;
            }
            else
            {
                IPaddr.Text = "127.0.0.1";
                Port_num.Text = "8080";
                IPaddr.ReadOnly = true;
                Port_num.ReadOnly = true;
            }
        }
        // check valid IP
        private bool IsIPaddr()
        {
            Match collection = Regex.Match(IPaddr.Text, @"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)(\.|$)){4}\b");
            if (collection.Value.Length <= 0) return false;
            return true;
        }
        // check valid Port number
        private bool IsPort()
        {
            Match collection = Regex.Match(Port_num.Text, @"^([0-9]{1,4}|[1-5][0-9]{4}|6[0-4][0-9]{3}|65[0-4][0-9]{2}|655[0-2][0-9]|6553[0-5])$");
            if (collection.Value.Length <= 0) return false;
            return true;
        }
        // check IP & Port num are empty or not
        private bool checkInputIsEmpty()
        {
            if (string.IsNullOrEmpty(IPaddr.Text) || string.IsNullOrWhiteSpace(IPaddr.Text)) return false; // ip
            if (string.IsNullOrEmpty(Port_num.Text) || string.IsNullOrWhiteSpace(Port_num.Text)) return false; // port
            return true;
        }
        TCPserver server = null;
        private void Run_Click(object sender, EventArgs e)
        {
            if (checkInputIsEmpty() == false)
            {
                MessageBox.Show("IP address or Port can not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsIPaddr() == false)
            {
                MessageBox.Show("IP address is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsPort() == false)
            {
                MessageBox.Show("Port is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            server = new TCPserver(IPaddr.Text, Int32.Parse(Port_num.Text), 4096, ConsoleForm, ListClient, 10485760); // 10485760 is number of bytes
            if (server.run() == 1) return;
            // Tat di nhung nut ko can thiet va bat nhung nut can thiet
            Run.Enabled = false;
            Automatic.Enabled = false;
            Stop.Enabled = true;
            Restart.Enabled = true;
        }

        private async void Stop_Click(object sender, EventArgs e)
        {
            if (server != null)
            {
                server.stop();
                await Task.Delay(5000); // delay xong roi moi tat nhung nut khong can thiet
                // Tat di nhung nut ko can thiet va bat lai nhung nut can thiet
                Stop.Enabled = false;
                Restart.Enabled = false;
                Run.Enabled = true;
                Automatic.Enabled = true;
            }
        }
        private async void Restart_Click(object sender, EventArgs e)
        {
            if (server != null)
            {
                Stop_Click(sender, e);
                await Task.Delay(5100);
                Run_Click(sender, e);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
