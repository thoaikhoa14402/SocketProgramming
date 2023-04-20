using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPClient
{
    public partial class ClientConnectForm : Form
    {
        public ClientConnectForm()
        {
            InitializeComponent();
        }
        private TCP_Clients client = null;

        private void Automatic_CheckedChanged(object sender, EventArgs e)
        {
            if (Automatic.Checked == false)
            {
                IPaddr.Text = string.Empty;
                Portnum.Text = string.Empty;
                IPaddr.ReadOnly = false;
                Portnum.ReadOnly = false;
            }
            else
            {
                IPaddr.Text = "127.0.0.1";
                Portnum.Text = "8080";
                IPaddr.ReadOnly = true;
                Portnum.ReadOnly = true;
            }
        }
        private void Connection_Click(object sender, EventArgs e)
        {
            try
            {
                if (client == null)
                {
                    client = new TCP_Clients(IPaddr.Text, Int32.Parse(Portnum.Text), 10485760); // 10000 is number of bytes
                    if (client.run())
                    {
                        Disconnection.Enabled = true;
                        Connection.Enabled = false;
                        UserLoginForm login = new UserLoginForm();
                        login.cli = client;
                        login.connectForm = this;
                        login.Show();
                        Hide();
                    }
                    else client = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Disconnection_Click(object sender, EventArgs e)
        {
           
            client.disconnect();
            client = null;
            MessageBox.Show("Disconnected to server successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Enabled = true;
            Disconnection.Enabled = false;
            IPaddr.ReadOnly = false;
            Portnum.ReadOnly = false;
            Automatic.Enabled = true;
            Automatic.Checked = false;
            IPaddr.Text = string.Empty;
            Portnum.Text = string.Empty;
        }
    }
}
