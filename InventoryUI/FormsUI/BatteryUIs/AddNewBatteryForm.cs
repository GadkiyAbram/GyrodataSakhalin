using InventoryLibrary;
using InventoryLibrary.Validation.BatteryValidation;
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
    public partial class AddNewBatteryForm : Form
    {
        public List<string> errorsBattery = new List<string>();

        public AddNewBatteryForm()
        {
            InitializeComponent();
        }

        private void addBatteryButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
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

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreateBattery(model);
                }
                MessageBox.Show($"Battery { batterySerialOneText.Text } added");
            }
            else
            {
                ErrorForm errorForm = new ErrorForm(errorsBattery);
                errorForm.Show();
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            errorsBattery.Clear();

            // Box validation
            string batteryBoxNumber = batteryBoxNumberText.Text;
            BoxNumberValidation itemValidation = new BoxNumberValidation(batteryBoxNumber);
            if (batteryBoxNumber == "")
            {
                output = false;
                errorsBattery.Add("Box couldn't be empty");
            }
            if (batteryBoxNumber.Length > 3)
            {
                output = false;
                errorsBattery.Add("Box Length should be <= 3");
            }
            if (!itemValidation.ValidateBoxNumber())
            {
                output = false;
                errorsBattery.Add("Wrong Box pattern");
            }

            // SerialOne validation
            string serialOne = batterySerialOneText.Text;
            SerialOneValidation serialOneValidation = new SerialOneValidation(serialOne);
            if (serialOne == "")
            {
                output = false;
                errorsBattery.Add("Serial 1 couldn't be empty");
            }
            if (serialOne.Length > 20)
            {
                output = false;
                errorsBattery.Add("Serial 1 Length should be <= 20");
            }
            if (!serialOneValidation.ValidateSerialOne())
            {
                output = false;
                errorsBattery.Add("Wrong Serial 1 pattern");
            }
            //TODO - Add CCD / Invoice validations

            return output;
        }
    }
}
