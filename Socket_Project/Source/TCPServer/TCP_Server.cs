using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Threading;
namespace TCP_Server
{
    class TCPserver
    {
        public TCPserver(string ipAddr, int port, int len_buffer, RichTextBox obj, RichTextBox obj2, int len = 10485760)
        {
            IP = ipAddr;
            PORT = port;
            buffer_len = len_buffer;
            buffer = new byte[len_buffer];
            ConsoleForm = obj;
            ListClient = obj2;
        }
        public int run()
        {
            ClientSocket = new List<Socket>();
            ListenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            if (ListenSocket == null)
            {
                MessageBox.Show("Create socket with error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            try
            {
                ListenSocket.Bind(new IPEndPoint(IPAddress.Parse(IP), PORT));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            ListenSocket.Listen(0); // always listen

            // Get Data from Web
            newT = new Thread(async() =>
            {
                while (true)
                {
                    // check whether folder is existing in folder or not
                    if (Directory.Exists("DB/") == false) Directory.CreateDirectory("DB/");
                    if (Directory.Exists("DB/GoldRate") == false) Directory.CreateDirectory("DB/GoldRate/");

                    // Get data from web json file
                    HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://tygia.com/json.php?ran=0&rate=0&gold=1&bank=0&date=now");
                    httpWebRequest.Method = WebRequestMethods.Http.Get;
                    httpWebRequest.Accept = "application/json";
                    WebResponse response = await httpWebRequest.GetResponseAsync();
                    string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    // write data from web to file ( by date,month,year)
                    DateTime date = DateTime.Now.Date;
                    string filename = date.Day + "-" + date.Month + "-" + date.Year;
                   
                    // write to file DB (data base)
                    File.WriteAllText("DB/GoldRate/" + filename + ".json", responseString);
                    // Analysis json file
                    Thread.Sleep(1000 * 60 * 30); // 30p (don vi ms)
                }
            });
            newT.Start();

            // clear previous session (client's account) (xoa phien lam viec cua account neu nhu server sap dot ngot)
            Dictionary<string, Dictionary<string, string>> DB = GetAccountDataBase();
            DB["session"].Clear();
            // after that, re-write DB
            string jsonstr = JsonConvert.SerializeObject(DB);
            File.WriteAllText("DB/accounts.json", jsonstr);

            // write on console form
            TCPinvoke("Server is running...\n",ConsoleForm);
            // begin accept
            ListenSocket.BeginAccept(AcceptCallback, null);
            return 0;
        }

        private bool IsConnected(Socket socket)
        {
            try
            {
                return !(socket.Poll(1, SelectMode.SelectRead) && socket.Available == 0);
            }
            catch (SocketException)
            {
                return false;
            }
        }
        // xu ly song song
        private void AcceptCallback(IAsyncResult AR)
        {
            Socket socket;
            try
            {
                socket = ListenSocket.EndAccept(AR);
            }
            catch (ObjectDisposedException)
            {
                MessageBox.Show("Server closed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ClientSocket.Add(socket);

            // Show on left-hand form
            string clientIP = ((IPEndPoint)socket.RemoteEndPoint).Address.ToString();
            string clientPort = ((IPEndPoint)socket.RemoteEndPoint).Port.ToString();
            TCPinvoke("Client IP: " + clientIP + " - Port: " + clientPort + "\n", ListClient); // write on form list client
            socket.BeginReceive(buffer, 0, buffer_len, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
            ListenSocket.BeginAccept(AcceptCallback, null);
        }

       

        private static List<string> search()
        {
            return null;
        }
        private void SendCallback(IAsyncResult AR)
        {
            try
            {
                Socket socket = (Socket)AR.AsyncState;
                socket.EndSend(AR);
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ObjectDisposedException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Get account data base
        private Dictionary<string, Dictionary<string, string>> GetAccountDataBase()
        {
            // if file does not exist in folder , create it
            if (File.Exists("DB/accounts.json") == false) File.WriteAllText("DB/accounts.json", "{\"username\":{},\"password\":{},\"session\":{},\"id\":{\"number\":\"999\"}}");
            Dictionary<string, Dictionary<string, string>> Object = new Dictionary<string, Dictionary<string, string>>();
            string json = File.ReadAllText("DB/accounts.json");

            Object = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json);
            return Object;
        }

        private static void get_data_by_date(string date)
        {
            // check whether folder is existing in folder or not
            if (Directory.Exists("DB/") == false) Directory.CreateDirectory("DB/");
            if (Directory.Exists("DB/GoldRate") == false) Directory.CreateDirectory("DB/GoldRate/");
            string[] fmats = date.Split('-');
            string day = (Int32.Parse(fmats[0]) < 10) ? "0" + fmats[0] : fmats[0];
            string month = (Int32.Parse(fmats[1]) < 10) ? "0" + fmats[1] : fmats[1];
            string year = fmats[2];
            string get_date = year + month + day;
            // Get data from web json file
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://tygia.com/json.php?ran=0&rate=0&gold=1&bank=0&date=" + get_date);
            httpWebRequest.Method = WebRequestMethods.Http.Get;
            httpWebRequest.Accept = "application/json";
            WebResponse response = httpWebRequest.GetResponse();
            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            string fileNameT = date;
            // write to file DB (data base)
            File.WriteAllText("DB/GoldRate/" + fileNameT + ".json", responseString);
        }
        private void ReceiveCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received;

            if (IsConnected(current) == false)
            {
                string clientIP = ((IPEndPoint)current.RemoteEndPoint).Address.ToString();
                string clientPort = ((IPEndPoint)current.RemoteEndPoint).Port.ToString();
                //TCPinvoke("Client disconnected\n",ConsoleForm);
                ReplaceInvoke(ListClient,"Client IP: " + clientIP + " - Port: " + clientPort + "\n",""); // write on form ListClient
                current.Close();
                ClientSocket.Remove(current);
                return;
            }
            try
            {
                received = current.EndReceive(AR);
            }
            catch (Exception)
            {
                TCPinvoke("Client disconnected\n",ConsoleForm);
                current.Close();
                ClientSocket.Remove(current);
                return;
            }



            // Request "register" from client
            byte[] recBuf = new byte[received];
            Array.Copy(buffer, recBuf, received);
            string json = Encoding.UTF8.GetString(recBuf);

            Dictionary<string, string> Object = new Dictionary<string, string>();
            Object = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            try
            {
                // no action ==> return
                if (Object.ContainsKey("action") == false) return;
                // action == "login" or action == "register"
                if (Object["action"] == "login" || Object["action"] == "register" || Object["action"] == "logout")
                {
                    Dictionary<string, Dictionary<string, string>> DB = GetAccountDataBase();
                    // action == "register"
                    if (Object["action"] == "register")
                    {
                        if (Object.ContainsKey("username") == false || Object.ContainsKey("password") == false) return; // no username or password ==>  return
                        if (DB["username"].ContainsKey(Object["username"]) == true)
                        {
                            byte[] sendData = Encoding.UTF8.GetBytes("{\"action\":\"register\", \"status\":\"error\", \"info\":\"Username already exists !\"}");
                            current.BeginSend(sendData, 0, sendData.Length, SocketFlags.None, new AsyncCallback(SendCallback), current);
                        }
                        else
                        {
                            string id = (Int32.Parse(DB["id"]["number"]) + 1).ToString();
                            DB["username"].Add(Object["username"], id);
                            DB["password"].Add(id, Object["password"]);
                            DB["id"]["number"] = id;
                            string jsonstr = JsonConvert.SerializeObject(DB);
                            File.WriteAllText("DB/accounts.json", jsonstr);
                            // write on console form
                            string clientIP = ((IPEndPoint)current.RemoteEndPoint).Address.ToString();
                            string clientPort = ((IPEndPoint)current.RemoteEndPoint).Port.ToString();
                            // send response
                            byte[] sendData = Encoding.UTF8.GetBytes("{\"action\":\"register\", \"status\":\"success\"}");
                            current.BeginSend(sendData, 0, sendData.Length, SocketFlags.None, new AsyncCallback(SendCallback), current);
                            TCPinvoke("Client IP: " + clientIP + " - Port: " + clientPort + " signed up - " + "Username: " + Object["username"] + "\n", ConsoleForm);
                        }
                    }
                    else if (Object["action"] == "login") // action == "login"
                    {
                        if (Object.ContainsKey("username") == false || Object.ContainsKey("password") == false) return; // no username or password ==>  return
                                                                                                                        // check if username is existing in DB or not
                        if (DB["username"].ContainsKey(Object["username"]) == true) // existent
                        {
                            string id = DB["username"][Object["username"]];

                            // check session in real time
                            if (DB["session"].ContainsKey(id) == false)
                            {
                                string pass = DB["password"][id];
                                if (pass == Object["password"] && pass.Length == Object["password"].Length)
                                {
                                    // create random token
                                    var allChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                                    var random = new Random();
                                    var resultToken = new string(
                                       Enumerable.Repeat(allChar, 8)
                                       .Select(token => token[random.Next(token.Length)]).ToArray());
                                    string authToken = resultToken.ToString();
                                    DB["session"][id] = authToken;
                                    string jsontr = JsonConvert.SerializeObject(DB);
                                    File.WriteAllText("DB/accounts.json", jsontr);
                                    // write on console form
                                    string clientIP = ((IPEndPoint)current.RemoteEndPoint).Address.ToString();
                                    string clientPort = ((IPEndPoint)current.RemoteEndPoint).Port.ToString();
                                    byte[] sendData = Encoding.UTF8.GetBytes("{\"action\":\"login\", \"status\":\"success\", \"username\":\"" + Object["username"] + "\", \"session\":\"" + DB["session"][id] + "\", \"id\":\"" + id + "\"}");
                                    current.BeginSend(sendData, 0, sendData.Length, SocketFlags.None, new AsyncCallback(SendCallback), current);
                                    TCPinvoke("Client IP: " + clientIP + " - Port: " + clientPort + " has logged in - " + "Username: " + Object["username"] + "\n", ConsoleForm);
                                }
                                else
                                {
                                    byte[] sendData = Encoding.UTF8.GetBytes("{\"action\":\"login\", \"status\":\"error\", \"info\":\"Invalid username or password !\"}");
                                    current.BeginSend(sendData, 0, sendData.Length, SocketFlags.None, new AsyncCallback(SendCallback), current);
                                }
                            }
                            // if login in real-time now ==> notification 
                            else
                            {
                                byte[] sendData = Encoding.UTF8.GetBytes("{\"action\":\"login\", \"status\":\"error\", \"info\":\"Your account has already logged in!\"}");
                                current.BeginSend(sendData, 0, sendData.Length, SocketFlags.None, new AsyncCallback(SendCallback), current);
                            }

                        }
                        // no username in data base (non-existent)
                        else
                        {
                            byte[] sendData = Encoding.UTF8.GetBytes("{\"action\":\"login\", \"status\":\"error\", \"info\":\"Username does not exist! Please register an account !\"}");
                            current.BeginSend(sendData, 0, sendData.Length, SocketFlags.None, new AsyncCallback(SendCallback), current);
                        }
                    }
                    else if (Object["action"] == "logout")
                    {
                        if (Object.ContainsKey("id") == false) return;
                        else
                        {
                            DB["session"].Remove(Object["id"]);
                            string jsonstr = JsonConvert.SerializeObject(DB);
                            // write on console form
                            string clientIP = ((IPEndPoint)current.RemoteEndPoint).Address.ToString();
                            string clientPort = ((IPEndPoint)current.RemoteEndPoint).Port.ToString();
                            File.WriteAllText("DB/accounts.json", jsonstr);
                            byte[] sendData = Encoding.UTF8.GetBytes("{\"action\":\"logout\", \"status\":\"success\"}");
                            current.BeginSend(sendData, 0, sendData.Length, SocketFlags.None, new AsyncCallback(SendCallback), current);
                            TCPinvoke("Client IP: " + clientIP + " - Port: " + clientPort + " logged out - " + "Username: " + Object["username"] + "\n", ConsoleForm);
                        }
                    }
                }
                else if (Object["action"] == "option")
                {
                    string company = null, type = null, brand = null;
                    fetch_option(ref company, ref type, ref brand);
                    string response = "{\"action\":\"option\", \"company\":\"" + company + "\", \"type\":\"" + type + "\", \"brand\":\"" + brand + "\"}";
                    byte[] sendData = Encoding.UTF8.GetBytes(response);
                    current.BeginSend(sendData, 0, sendData.Length, SocketFlags.None, new AsyncCallback(SendCallback), current);
                }
                else if (Object["action"] == "search")
                {
                    if (!Object.ContainsKey("date") || !Object.ContainsKey("company") || !Object.ContainsKey("type") || !Object.ContainsKey("brand")) return;
                    // if file data does not exist, create it, using get_data_by_date function
                    // Tuc la neu search theo ngay nhung trong folder chua co file data thi
                    // tao ra file theo ngay cua client muon (mac dinh la ngay hien tai)
                    if (Object["date"] != "Default" && File.Exists("DB/GoldRate/" + Object["date"] + ".json") == false) {
                        get_data_by_date(Object["date"]);
                    }
                    string data = search(Object["date"], Object["company"], Object["type"], Object["brand"]);
                    string response = "{\"action\":\"search\",\"value\":" + data + "}";
                    byte[] sendData = Encoding.UTF8.GetBytes(response);
                    current.BeginSend(sendData, 0, sendData.Length, SocketFlags.None, new AsyncCallback(SendCallback), current);
                }
                // continue receive request
                current.BeginReceive(buffer, 0, buffer_len, SocketFlags.None, new AsyncCallback(ReceiveCallback), current);
            }
            // catch  exception
            catch (SocketException) { } 
            catch (ObjectDisposedException){ }
        }
        // get data from file json and using for searching form
        private static string fetch_data(string filename = "Default")
        {
            if (filename.IndexOf("Default") >= 0)
            {
                DateTime todaysDate = DateTime.Now.Date;
                filename = todaysDate.Day + "-" + todaysDate.Month + "-" + todaysDate.Year;
            }

            string data = File.ReadAllText("DB/GoldRate/" + filename + ".json");
            if (!string.IsNullOrEmpty(data) && !string.IsNullOrWhiteSpace(data))
            {
                JToken obj = JsonConvert.DeserializeObject<JToken>(data);

                JArray Ginfo = obj.First.First.First.Last.First.Value<JArray>();

                string json = JsonConvert.SerializeObject(Ginfo);
                return json;
            }
 
            return null;
        }

        // get option data from client's request.
        private static void fetch_option(ref string company, ref string type, ref string brand)
        {
            JArray GoldArr = JsonConvert.DeserializeObject<JArray>(fetch_data());
            Dictionary<string, string> GoldInfo;
            Dictionary<string, bool> flag = new Dictionary<string, bool>(); // use for marking the string which was selected
            foreach (JToken obj in GoldArr)
            {
                GoldInfo = JsonConvert.DeserializeObject<Dictionary<string, string>>(obj.ToString());
                if (flag.ContainsKey(GoldInfo["company"]) == false)
                {
                    company += GoldInfo["company"] + ",";
                    flag.Add(GoldInfo["company"], true);
                }
                if (flag.ContainsKey(GoldInfo["type"]) == false)
                {
                    type += GoldInfo["type"] + ",";
                    flag.Add(GoldInfo["type"], true);
                }
                if (flag.ContainsKey(GoldInfo["brand"]) == false)
                {
                    brand += GoldInfo["brand"] + ",";
                    flag.Add(GoldInfo["brand"], true);
                }
            }
            company = company.Remove(company.Length - 1, 1); // remove last ","
            type = type.Remove(type.Length - 1, 1); // remove last ","
            brand = brand.Remove(brand.Length - 1, 1); // remove last ","
        }
       
        // process searching form
        private static string search(string date, string company, string type, string brand)
        {
            List<string> goldRateData = new List<string>();
            JArray Ginfo = JsonConvert.DeserializeObject<JArray>(fetch_data(date));
            Dictionary<string, string> GoldArr;
            if (company == null || type == null || brand == null) return null;
            foreach (JToken jsonObj in Ginfo)
            {
                //GoldArr = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonObj.ToString());
                GoldArr = jsonObj.ToObject<Dictionary<string, string>>();
                if (!GoldArr.ContainsKey("company") || !GoldArr.ContainsKey("brand") || !GoldArr.ContainsKey("type")) continue;
                if (brand != "Default" && GoldArr["brand"].IndexOf(brand) < 0) continue;
                if (company != "Default" && GoldArr["company"].IndexOf(company) <  0) continue;
                if (type != "Default" && GoldArr["type"].IndexOf(type) < 0) continue; // indexof uses for checking substring
               
                goldRateData.Add(jsonObj.ToString());
            }
            string json = JsonConvert.SerializeObject(goldRateData);
            return (json.Length > 0) ? json : null;
        }
        public void stop()
        {
            try
            {
                DateTime todaysDate = DateTime.Now.Date;
                string filename = todaysDate.Day + "-" + todaysDate.Month + "-" + todaysDate.Year + "-" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();

                if (Directory.Exists("Logs/") == false) Directory.CreateDirectory("Logs/");
                if (Directory.Exists("Logs/" + DateTime.Now.Date.Day + "-" + DateTime.Now.Date.Month + "-" + DateTime.Now.Date.Year) == false)
                    Directory.CreateDirectory("Logs/" + DateTime.Now.Date.Day + "-" + DateTime.Now.Date.Month + "-" + DateTime.Now.Date.Year);

                File.WriteAllText("Logs/" + DateTime.Now.Date.Day + "-" + DateTime.Now.Date.Month + "-" + DateTime.Now.Date.Year + "/" + filename + ".log", ConsoleForm.Text);
                // stop server and starting countdown
                countTimer = 5;
                var sendData = Encoding.UTF8.GetBytes("Server will close after " + countTimer.ToString() + " seconds.\r\n");
                ConsoleForm.Text = Encoding.UTF8.GetString(sendData);
                //TCPinvoke_2(Encoding.UTF8.GetString(sendData));
                StartAsyncTimedWork();
                ClearInvoke(ConsoleForm);
            }
            catch (SocketException) { }
            catch (ObjectDisposedException) { }
        }
        private void StartAsyncTimedWork()
        {
            offset.Tick += new EventHandler(Timer_Tick);
            offset.Start();
            offset.Interval = 999;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            countTimer--;
            var sendData = Encoding.UTF8.GetBytes("Server will close after " + countTimer.ToString() + " seconds.\r\n");
            // ConsoleForm.Text = Encoding.UTF8.GetString(sendData);
            TCPinvoke_2(Encoding.UTF8.GetString(sendData),ConsoleForm);
            if (countTimer == 0)
            {
                offset.Stop();
                offset.Tick -= Timer_Tick;
                byte[] sendData_client = Encoding.UTF8.GetBytes("{\"action\":\"server-closed\",\"info\":\"Server was closed !\"}");
                foreach (Socket socket in ClientSocket)
                {
                    socket.BeginSend(sendData_client, 0, sendData_client.Length, SocketFlags.None, new AsyncCallback(SendCallback), socket);
                }
                CloseAllSockets();
            }
        }
        private void CloseAllSockets()
        {
            try
            {
                ClearInvoke(ListClient);
                foreach (Socket socket in ClientSocket)
                {
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Disconnect(false);
                }
                ListenSocket.Close();
                newT.Abort();
                TCPinvoke_2("Server closed\n", ConsoleForm);
                GC.Collect();
            }
            
            catch(SocketException) { }
            catch(ObjectDisposedException) { }
        }

        void TCPinvoke(string text, RichTextBox current)
        {
            if (current.IsDisposed == false)
            {
                current.Invoke(new MethodInvoker(delegate {
                    current.Text += text;
                }));
            }
        }
        // gui thong bao ve client
        void TCPinvoke_2(string text, RichTextBox current)
        {
            if (current.IsDisposed == false)
            {
                current.Invoke(new MethodInvoker(delegate { current.Text = text; }));
            }
        }

        // Write on form list client
        private void ReplaceInvoke(RichTextBox obj, string strdOld, string strNew)
        {
            if (obj.IsDisposed == false)
            {
                obj.Invoke(new MethodInvoker(delegate {
                    obj.Text = obj.Text.Replace(strdOld, strNew);
                }));
            }
        }

        private static void ClearInvoke(RichTextBox current)
        {
            if (current.IsDisposed == false)
            {
                current.Invoke(new MethodInvoker(delegate {
                    current.Clear();
                }));
            }
        }
        ~TCPserver()
        {
            CloseAllSockets();
        }
        private string IP;
        private int PORT;
        private int buffer_len;
        private byte[] buffer;
        private Socket ListenSocket;
        private List<Socket> ClientSocket;
        private static Thread newT;
        private RichTextBox ConsoleForm, ListClient;
        private System.Windows.Forms.Timer offset = new System.Windows.Forms.Timer();
        private int countTimer;
    }
}


