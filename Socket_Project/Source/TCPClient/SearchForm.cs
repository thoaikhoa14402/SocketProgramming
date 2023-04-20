using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPClient
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        private TCP_Clients client = null;
        private Form connect = null;
        public TCP_Clients cli
        {
            set { client = value; }
        }
        public Form connectForm
        {
            set { connect = value; }
        }
        private void FormLogin()
        {
            UserLoginForm login = new UserLoginForm();
            login.cli = client;
            login.connectForm = connect;
            login.Show();
            Close();
        } 
        private void Logout_button_Click(object sender, EventArgs e)
        {
            client.RequestLogout(client.id,client.UserAccount);
            client.ReceiveResponse();
            FormLogin();
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client.Session != null)
            {
                Logout_button_Click(sender, new EventArgs());
            }
           
        }


        private void SearchForm_Load(object sender, EventArgs e)
        {
            if (client.Session == null) Close();
            else
            {
                Title.Text += client.UserAccount; // hello user
                // request option:  brand ? type ? or area?
                client.RequestOption();
                client.ReceiveResponse(); // receive request option
                // check valid search option
                if (client.SearchOption.Count > 0)
                {
                    // add to combobox
                   foreach (string obj in client.SearchOption["company"]) CompanyBox.Items.Add(obj);
                   foreach (string obj in client.SearchOption["type"]) TypeBox.Items.Add(obj);   
                   foreach (string obj in client.SearchOption["brand"]) BrandBox.Items.Add(obj);

                }
                else
                {
                    MessageBox.Show("Load option failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Request all infor (brand, type, area, date) in file  and display in data table ( mode default )
                client.RequestSearch("Default", "Default", "Default", "Default");
                client.ReceiveResponse();

                string[] Item = new string[6];
                ListViewItem LItems;
                if (client.goldRateData == null) return;
                foreach (Dictionary<string,string> child in client.goldRateData)
                {
                    Item[0] = child["type"];
                    Item[1] = child["company"];
                    Item[2] = child["brand"];
                    Item[3] = child["buy"];
                    Item[4] = child["sell"];
                    Item[5] = child["updated"]; //date
                    LItems = new ListViewItem(Item);
                    DataTable.Items.Add(LItems);
                }
            }
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            if (DateBox.Value > DateTime.Now)
            {
                MessageBox.Show("Invalid date", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string company = (string.IsNullOrEmpty(CompanyBox.Text) || string.IsNullOrWhiteSpace(CompanyBox.Text)) ? "Default" : CompanyBox.Text;
            string type = (string.IsNullOrEmpty(TypeBox.Text) || string.IsNullOrWhiteSpace(TypeBox.Text)) ? "Default" : TypeBox.Text;
            string brand = (string.IsNullOrEmpty(BrandBox.Text) || string.IsNullOrWhiteSpace(BrandBox.Text)) ? "Default" : BrandBox.Text;
            string date = DateBox.Value.Day + "-" + DateBox.Value.Month + "-" + DateBox.Value.Year;
            
            client.RequestSearch(date, company, type, brand);
            client.ReceiveResponse();
            // update data table
            DataTable.Items.Clear(); //  clear old data of items in data table
            string[] Item = new string[6];
            ListViewItem LItems;
            if (client.goldRateData == null) return;
            foreach (Dictionary<string, string> child in client.goldRateData)
            {
                Item[0] = child["type"];
                Item[1] = child["company"];
                Item[2] = child["brand"];
                Item[3] = child["buy"];
                Item[4] = child["sell"];
                Item[5] = child["updated"]; //date
                // add new row
                LItems = new ListViewItem(Item);
                DataTable.Items.Add(LItems);
            }
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            client.RequestSearch("Default", "Default", "Default", "Default");
            client.ReceiveResponse();
            CompanyBox.Text = "";
            TypeBox.Text = "";
            BrandBox.Text = "";
            DateBox.Text = "";

            DataTable.Items.Clear();

            string[] Item = new string[6];
            ListViewItem LItems;
            if (client.goldRateData == null) return;
            foreach (Dictionary<string, string> child in client.goldRateData)
            {
                Item[0] = child["type"];
                Item[1] = child["company"];
                Item[2] = child["brand"];
                Item[3] = child["buy"];
                Item[4] = child["sell"];
                Item[5] = child["updated"]; //date
                // add new row
                LItems = new ListViewItem(Item);
                DataTable.Items.Add(LItems);
            }
        }

    }
}
