using InventoryLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryUI
{
    public partial class LithiumBatteriesForm : Form
    {
        public LithiumBatteriesForm()
        {
            InitializeComponent();
            BatteriesAllLoad();
        }

        private void AddNewBatteryLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewBatteryForm addNewBattery = new AddNewBatteryForm();
            addNewBattery.Show();
        }

        private void BatteriesAllLoad()
        {
            batteriesGridView.DataSource = SqlConnector.GetCustomBatteryData("", "");

        }

        private void BatteriesCustomLoad(string what, string where)
        {
            batteriesGridView.DataSource = SqlConnector.GetCustomBatteryData(what, where);
        }

        private void refreshbatteryButton_Click(object sender, EventArgs e)
        {
            switch (searchBatteryComboBox.Text)
            {
                case "Serial 1":
                    BatteriesCustomLoad(searchBatteryText.Text, "Serial 1");
                    break;
                case "Status":
                    BatteriesCustomLoad(searchBatteryText.Text, "Status");
                    break;
                case "CCD":
                    BatteriesCustomLoad(searchBatteryText.Text, "CCD");
                    break;
                case "Invoice":
                    BatteriesCustomLoad(searchBatteryText.Text, "Invoice");
                    break;
                case "":
                    BatteriesCustomLoad("", "");
                    break;
            }
        }
    }
}
