using InventoryLibrary;
using InventoryLibrary.Validation.BatteryValidation;
using InventoryUI.Validation.BatteryValidation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryUI
{
    public partial class AddNewBatteryForm : Form
    {
        string pathBatteriesAdd = "PathBatteriesAdd";
        public List<string> errorsBattery = new List<string>();

        public AddNewBatteryForm()
        {
            InitializeComponent();
            conditionComboBox.SelectedIndex = 0;
        }

        private void addBatteryButton_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (ValidateForm().Keys.First())
            {
                BatteryModel model = new BatteryModel(
                        batteryBoxNumberText.Text,          // check length, pattern
                        conditionComboBox.Text,
                        batterySerialOneText.Text,       // check length, pattern
                        batterySerialTwoText.Text,       // check length, pattern
                        batterySerialThreeText.Text,           // check length, pattern
                        batteryCcdText.Text,
                        batteryInvoiceText.Text,   // check length, pattern
                        batteryStatusText.Text,        // check length
                        batteryArrivedText.Text,           // check length
                        batteryContainerText.Text,     // check length
                        batteryCommentText.Text        // check length
                        );

                result = ApiHelpers.ApiConnectorHelper.SaveData<BatteryModel>(model, pathBatteriesAdd);
                if (result != 0)
                {
                    MessageBox.Show($"Battery { batterySerialOneText.Text } added");
                }
                else
                {
                    MessageBox.Show("Smth went wrong");
                }
            }
            else
            {
                ErrorForm errorForm = new ErrorForm(ValidateForm().Values.First());
                errorForm.Show();
            }
        }

        private Dictionary<bool, List<string>> ValidateForm()
        {
            Dictionary<string, string> batteryFields = new Dictionary<string, string>();
            batteryFields.Add("batteryBoxNumber", batteryBoxNumberText.Text);
            batteryFields.Add("serialOne", batterySerialOneText.Text);
            batteryFields.Add("batteryCCD", batteryCcdText.Text);
            batteryFields.Add("batteryInvoice", batteryInvoiceText.Text);
            batteryFields.Add("batteryArrived", batteryArrivedText.Text);
            batteryFields.Add("batteryContainer", batteryContainerText.Text);

            var output = BatteryValidation.ValidateBattery(batteryFields);

            return output;
        }

        //private bool ValidateForm()
        //{
        //    bool output = true;
        //    errorsBattery.Clear();

        //    // Box validation
        //    string batteryBoxNumber = batteryBoxNumberText.Text;
        //    string batteryBoxPattern = @"^([1-9]+)$";
        //    if (batteryBoxNumber.Length == 0)
        //    {
        //        output = false;
        //        errorsBattery.Add("Box couldn't be empty");
        //    }
        //    if (batteryBoxNumber.Length > 2)
        //    {
        //        output = false;
        //        errorsBattery.Add("Box Length should be <= 2");
        //    }
        //    if (!UnitValidation.Validate(batteryBoxNumber, batteryBoxPattern))
        //    {
        //        output = false;
        //        errorsBattery.Add("Wrong Box pattern");
        //    }

        //    // SerialOne validation
        //    string serialOne = batterySerialOneText.Text;
        //    string serialOnePattern = @"^(S1-[0-9]{4})-([0-9]{4})$";
        //    if (serialOne.Length == 0)
        //    {
        //        output = false;
        //        errorsBattery.Add("Serial 1 couldn't be empty");
        //    }
        //    if (serialOne.Length > 12)
        //    {
        //        output = false;
        //        errorsBattery.Add("Serial 1 Length should be = 12");
        //    }
        //    if (!UnitValidation.Validate(serialOne, serialOnePattern))
        //    {
        //        output = false;
        //        errorsBattery.Add("Wrong Serial 1 pattern");
        //    }

        //    // CCD validation
        //    string batteryCCD = batteryCcdText.Text;
        //    string batteryCcdPattern = @"^([0-9]{8})-([0-9]{6})-([0-9]{7})$";   // 10707090-021017-0013452
        //    if (batteryCCD.Length == 0)
        //    {
        //        output = false;
        //        errorsBattery.Add("CCD couldn't be empty");
        //    }
        //    if (batteryCCD.Length > 25)
        //    {
        //        output = false;
        //        errorsBattery.Add("CCD Length should be <= 25");
        //    }
        //    if (!UnitValidation.Validate(batteryCCD, batteryCcdPattern))
        //    {
        //        output = false;
        //        errorsBattery.Add("Wrong CCD pattern");
        //    }

        //    // Invoice validation
        //    string batteryInvoice = batteryInvoiceText.Text;
        //    string batteryInvoicePattern = @"^([A-Z])\/([0-9]{2})\/([0-9]{2})$";
        //    if (batteryInvoice.Length == 0)
        //    {
        //        output = false;
        //        errorsBattery.Add("Invoice couldn't be empty");
        //    }
        //    if (batteryCCD.Length > 10)
        //    {
        //        output = false;
        //        errorsBattery.Add("Invoice Length should be <= 10");
        //    }
        //    if (!UnitValidation.Validate(batteryInvoice, batteryInvoicePattern))
        //    {
        //        output = false;
        //        errorsBattery.Add("Wrong Invoice pattern");
        //    }

        //    // Arrived Date validation
        //    string batteryArrived = batteryArrivedText.Text;
        //    string batteryArrivedPattern = @"^([0-9]{4})-([0-9]{2}-([0-9]{2}))$";
        //    if (batteryArrived.Length == 0)
        //    {
        //        output = false;
        //        errorsBattery.Add("Arriving date couldn't be empty");
        //    }
        //    if (batteryArrived.Length > 10)
        //    {
        //        output = false;
        //        errorsBattery.Add("Arriving date Length should be <= 10");
        //    }
        //    if (!UnitValidation.Validate(batteryArrived, batteryArrivedPattern))
        //    {
        //        output = false;
        //        errorsBattery.Add("Wrong Arriving date pattern");
        //    }

        //    // Container validation
        //    string batteryContainer = batteryContainerText.Text;
        //    if (batteryContainer.Length > 20)
        //    {
        //        errorsBattery.Add("Container Length should be <= 20");
        //    }

        //    return output;
        //}
    }
}
