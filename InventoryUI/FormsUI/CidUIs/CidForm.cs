using InventoryUI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryUI.FormsUI.CidUIs
{
    public partial class CidForm : Form
    {
        public CidForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> configData = ApiHelpers.ApiConnectorHelper.getConfigData();
            string host = configData["host"];
            string port = configData["port"];

            string host_no_scheme = null;

            if (host.Contains("http://")) {
                host_no_scheme = host.Replace("http://", "");
            }

            if (host.Contains("https://"))
            {
                host_no_scheme = host.Replace("http://", "");
            }


            label1.Text = host_no_scheme;
        }
    }
}
