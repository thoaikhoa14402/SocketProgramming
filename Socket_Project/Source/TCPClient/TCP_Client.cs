using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Threading;

namespace TCPClient
{
    public class TCP_Clients
    {
        public TCP_Clients(string IP, int port, int buffer_len = 10485760)
        {
            IPAddr = IPAddress.Parse(IP);
            Port = port;
            buff_size = buffer_len;
            ClientSocket = null;
            UserAccount = null;
            Session = null;
            id = -1;
        }
        public bool run()
        {
            if (connect() == false) return false;
            MessageBox.Show("Connected to server successfully", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;

        }
        public void SendRequest(string request)
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(request);
                ClientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
            }
           
            catch { }
        }

        // request logim
        public void RequestLogin(string username, string password)
        {
            string request = "{\"action\":\"login\", \"username\":\"" + username + "\", \"password\":\"" + password + "\"}";
            SendRequest(request);
        }
        // request register
        public void RequestRegister(string username, string password)
        {
            string request = "{\"action\":\"register\", \"username\":\"" + username + "\", \"password\":\"" + password + "\"}";
            SendRequest(request);
        }
        // request logout
        public void RequestLogout(int id, string username)
        {
            string request = "{\"action\":\"logout\",\"id\":\"" + id.ToString() + "\", \"username\":\"" + username + "\"}";
            SendRequest(request);
            UserAccount = null;
            Session = null;
            id = -1;
        }
        // search request for searching form
        public void RequestSearch(string date, string company, string type, string brand)
        {
            string request = "{\"action\":\"search\", \"date\":\"" + date + "\", \"company\":\"" + company + "\", \"type\":\"" + type + "\", \"brand\":\"" + brand + "\"}";
            SendRequest(request);
        }
        // option - type of data in searching form
        public void RequestOption()
        {
            string request = "{\"action\":\"option\"}";
            SendRequest(request);
        }
        public void ReceiveResponse()
        {
            try
            {
                byte[] responds = new byte[buff_size];
                int received = ClientSocket.Receive(responds, SocketFlags.None);
                if (received == 0) return;
                byte[] data = new byte[received];
                Array.Copy(responds, data, received);
                // get response from server
                string json = Encoding.UTF8.GetString(data);

                JToken Object2 = JsonConvert.DeserializeObject<JToken>(json);
                Dictionary<string, string> Object = new Dictionary<string, string>();

                if (Object2["action"].ToString() == "login" || Object2["action"].ToString() == "register" || Object2["action"].ToString() == "option" || Object2["action"].ToString() == "server-closed")
                {
                    Object = Object2.ToObject<Dictionary<string, string>>();
                }
                //if (Object.ContainsKey("action") == false) return;

                if (Object.ContainsKey("action") && Object["action"] == "register")
                {
                    if (Object.ContainsKey("status") == false) return;
                    if (Object["status"] == "success") MessageBox.Show("Register successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show(Object["info"], "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Object.ContainsKey("action") && Object["action"] == "login")
                {
                    if (Object.ContainsKey("status") == false) return;
                    if (Object["status"] == "success")
                    {
                        UserAccount = Object["username"];
                        Session = Object["session"];
                        id = Int32.Parse(Object["id"]);
                        MessageBox.Show("Login successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else MessageBox.Show(Object["info"], "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Object.ContainsKey("action") && Object["action"] == "option")
                {
                    if (Object.ContainsKey("company") == false || Object.ContainsKey("brand") == false || Object.ContainsKey("type") == false) return;
                    SearchOption = new Dictionary<string, List<string>>();
                    SearchOption.Add("company", Object["company"].Split(',').ToList());
                    SearchOption.Add("type", Object["type"].Split(',').ToList());
                    SearchOption.Add("brand", Object["brand"].Split(',').ToList());
                }
                else if (Object2["action"] != null && Object2["action"].ToString() == "search")
                {
                    goldRateData = new List<Dictionary<string, string>>();
                    JArray temp = Object2["value"].ToObject<JArray>();
                    foreach (JToken child in temp)
                    {
                        goldRateData.Add(JsonConvert.DeserializeObject<Dictionary<string, string>>(child.ToString()));
                    }

                }
                else if (Object.ContainsKey("action") && Object["action"] == "server-closed")
                {
                    disconnect();
                    MessageBox.Show(Object["info"], "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
            catch { }
        }
        private void RequestAsync()
        {
            MessageBox.Show("Client connected to server successfully", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool connect()
        {
            ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            if (ClientSocket == null)
            {
                MessageBox.Show("Client cannot create socket !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClientSocket.Connect(IPAddr, Port);
            if (!ClientSocket.Connected)
            {
                MessageBox.Show("Client cannot connect to server !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        public void disconnect()
        {
            try
            {
                ClientSocket.Shutdown(SocketShutdown.Both);
                ClientSocket.Disconnect(false);
                GC.Collect();
            }
            catch { };
            //Environment.Exit(0);
        }
        ~TCP_Clients()
        {
            disconnect();
        }

        public string UserAccount;
        public string Session;
        public int id;

        private Socket ClientSocket;
        private IPAddress IPAddr;
        private int Port;
        private int buff_size;
        private int buffer;
        // search response from server
        public Dictionary<string, List<string>> SearchOption;
        public List<Dictionary<string, string>> goldRateData;
    }
}
