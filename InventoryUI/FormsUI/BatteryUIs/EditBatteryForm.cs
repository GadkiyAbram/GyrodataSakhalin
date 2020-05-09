using InventoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InventoryUI.FormsUI.BatteryUIs
{
    public partial class EditBatteryForm : Form
    {
        string pathBatteryEdit = "PathBatteryEdit";
        string pathBatterySelected = "PathBatterySelected";
        int battery_id;
        public EditBatteryForm(List<BatteryModel> batteryList)
        {
            InitializeComponent();
            LoadAllBatteriesToComboBox(batteryList);
        }

        private void LoadAllBatteriesToComboBox(List<BatteryModel> batteryList)
        {
            // TODO - check if the jobList is NULL
            foreach (var battery in batteryList)
            {
                selectBatteryComboBox.Items.Add(battery.SerialOne);
            }
            selectBatteryComboBox.SelectedIndex = 0;
        }

        private void selectBatteryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFormWithBatteryFromComboBox(selectBatteryComboBox.Text);
        }

        private void LoadFormWithBatteryFromComboBox(string serial)
        {
            try
            {
                // TODO - refactor to use one function GetSelectedData, N/A for Tools
                BatteryModel batteryModel = ApiHelpers.ApiConnectorHelper.GetSelectedJobData<BatteryModel>(serial, pathBatterySelected).First();
                battery_id = batteryModel.Id;

                editBatteryBoxNumberText.Text = batteryModel.BoxNumber;
                editBatteryConditionText.Text = batteryModel.BatteryCondition;
                editBatterySerialOneText.Text = batteryModel.SerialOne;
                editBatterySerialTwoText.Text = batteryModel.SerialTwo;
                editBatterySerialThreeText.Text = batteryModel.SerialThr;
                editBatteryCcdText.Text = batteryModel.CCD;
                editBatteryInvoiceText.Text = batteryModel.Invoice;
                editBatteryStatusText.Text = batteryModel.BatteryStatus;
                editBatteryArrivedText.Text = batteryModel.Arrived;
                editBatteryContainerText.Text = batteryModel.Container;
                editBatteryCommentText.Text = batteryModel.Comment;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void editBatteryButton_Click(object sender, EventArgs e)
        {
            BatteryModel model = new BatteryModel(
                editBatteryBoxNumberText.Text,
                editBatteryConditionText.Text,
                editBatterySerialOneText.Text,
                editBatterySerialTwoText.Text,
                editBatterySerialThreeText.Text,
                editBatteryCcdText.Text,
                editBatteryInvoiceText.Text,
                editBatteryStatusText.Text,
                editBatteryArrivedText.Text,
                editBatteryContainerText.Text,
                editBatteryCommentText.Text
                );

            ApiHelpers.ApiConnectorHelper.EditData<BatteryModel>(battery_id.ToString(), model, pathBatteryEdit);
        }
    }
}
