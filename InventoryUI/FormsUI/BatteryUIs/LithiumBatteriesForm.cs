using InventoryLibrary;
using InventoryUI.ApiHelpers;
using InventoryUI.FormsUI.BatteryUIs;
using System;
using System.Windows.Forms;

namespace InventoryUI
{
    public partial class LithiumBatteriesForm : Form
    {
        string pathBatteriesAll = "PathBatteries";
        public static int countLithiumInstance = 0;
        public LithiumBatteriesForm()
        {
            InitializeComponent();
            countLithiumInstance++;
            searchBatteryComboBox.SelectedIndex = 0;
            BatteriesCustomLoad("", "", pathBatteriesAll);
        }

        private void AddNewBatteryLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewBatteryForm addNewBattery = new AddNewBatteryForm();
            addNewBattery.Show();
        }

        private void BatteriesCustomLoad(string what, string where, string path)
        {
            batteriesGridView.DataSource = ApiConnectorHelper.DataLoad<BatteryModel>(what, where, path);
        }

        // TODO - search by entering value, like Android - TextChechedListener
        private void refreshbatteryButton_Click(object sender, EventArgs e)
        {
            string searchBattery = searchBatteryText.Text;
            string searchItemComboBox = searchBatteryComboBox.Text;
            BatteriesCustomLoad(searchBatteryText.Text, searchItemComboBox, pathBatteriesAll);
        }

        private void LithiumBatteriesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            countLithiumInstance = 0;
        }

        private void editBatteryLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var batteryList = ApiConnectorHelper.DataLoad<BatteryModel>("", "", pathBatteriesAll);
            EditBatteryForm editBatteryForm = new EditBatteryForm(batteryList);
            editBatteryForm.Show();
        }
    }
}
