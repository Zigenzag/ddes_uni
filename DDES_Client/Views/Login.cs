using DDES_Server.Server;
using DDES_Client.Client;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDES_Client.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        async private void btn_login_Click(object sender, EventArgs e)
        {

            if (txt_username.Text.Length < 0 || txt_password.Text.Length < 0) return;

            JObject authRequestJson = new();
            JObject authRequestData = new();
            if (this.rad_account_teacher.Checked)
            {
                authRequestJson.Add("Module", "Teacher");
            }
            else
            {
                authRequestJson.Add("Module", "Parent");
            }
            authRequestJson.Add("Action", "Login");

            authRequestData.Add("UserName", (string)txt_username.Text);
            authRequestData.Add("Password", (string)txt_password.Text);

            authRequestJson.Add("Data", authRequestData);

            //JObject response = await Task.Run(() =>
            await Task.Run(() =>
            {
                JObject response = ServerClient.Request(authRequestJson);
                string err = response.ToString();
                throw new Exception(err);
            });
                
            //MessageBox.Show(response.ToString(), "RESULTS");



        }
    }
}
