using InventoryLibrary.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryUI.FormsUI.SettingsUI
{
    public partial class SettingsForm : Form
    {
        public static int countExtrasInstance = 0;
        public SettingsForm()
        {
            InitializeComponent();
            LoadInitialUrlPortData();
            loadConfigValues();
            countExtrasInstance++;
        }

        private void ExtrasForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            countExtrasInstance = 0;
        }

        private void LoadInitialUrlPortData()
        {
            //urlText.Text = Properties.Settings.Default.Host;
            //portText.Text = Convert.ToString(Properties.Settings.Default.Port);
            tokenFromSettingsText.Text = ConfigurationManager.AppSettings["Token"];
        }

        // TODO - move to ApiConnectorHelper
        private Uri UriConnection()
        {
            UriBuilder uriBuilder = new UriBuilder();
            uriBuilder.Scheme = "http";
            uriBuilder.Host = Properties.Settings.Default.Host;
            if (Properties.Settings.Default.Port != 0) {
                uriBuilder.Port = Properties.Settings.Default.Port;
            }
            uriBuilder.Path = System.Configuration.ConfigurationManager.AppSettings["PathAuth"];

            //tokenFromSettingsText.Text = uriBuilder.ToString();

            return uriBuilder.Uri;
        }

        private void getTokenButton_Click(object sender, EventArgs e)
        {
            string result = null;
            Uri uriAuth = UriConnection();        // change if the port is NULL not ot add
            //string uriAuth = "http://demotestapi.cloudapp.net/AuthServices/AuthService.svc/Authenticate";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(uriAuth);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var auth = new AuthModel { User = usernameText.Text, Password = passwordText.Text};
                var authSerialized = JsonConvert.SerializeObject(auth);
                streamWriter.Write(authSerialized);

                //string json = "{\"User\":\"user1\"," +
                //                "\"Password\":\"pass1\"}";
                //var serializedAuth = new DataContractJsonSerializer(typeof(AuthModel)).ToString();
            }
            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                    result = result.Replace("\\", "");
                    string correctedResult = result.Substring(1, result.Length - 2);
                    System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["Token"].Value = correctedResult;
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                }
            }
            catch (WebException webEx)
            {
                MessageBox.Show(webEx.ToString());
            }
        }

        private void tokenFromSettingsButton_Click(object sender, EventArgs e)
        {
            //urlText.Text = Properties.Settings.Default.Host;
            //portText.Text = Convert.ToString(Properties.Settings.Default.Port);
            string token = System.Configuration.ConfigurationManager.AppSettings["Token"];
            tokenFromSettingsText.Text = token;
        }

        private void loadConfigValues() 
        {
            Dictionary<string, string> configData = ApiHelpers.ApiConnectorHelper.getConfigData();
            //urlText.Text = configData["host"];
            //portText.Text = configData["port"];

            //string host = urlText.Text;
            //string port = portText.Text;

            string host = configData["host"];
            string host_no_scheme = host.Replace("http://", "");
            string port = configData["port"];

            Properties.Settings.Default.Host = host_no_scheme;
            Properties.Settings.Default.Port = Convert.ToInt32(port);
            Properties.Settings.Default.Save();

            UrlTextBox.Text = host_no_scheme;
            PortTextBox.Text = port;

            //MessageBox.Show(Properties.Settings.Default.Host.ToString());

        }

        // TODO - DELETE AFTER
        private void btnReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        //private void saveUrlPortButton_Click(object sender, EventArgs e)
        //{
        //    string host = urlText.Text;
        //    string port = portText.Text;

        //    Properties.Settings.Default.Host = host;
        //    Properties.Settings.Default.Port = Convert.ToInt32(port);
        //    Properties.Settings.Default.Save();
        //}
    }
}
