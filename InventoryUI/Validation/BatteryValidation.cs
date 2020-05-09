using InventoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryUI.Validation.BatteryValidation
{
    public class BatteryValidation
    {
        static string PathBatterySelected = "PathBatterySelected";

        public static Dictionary<bool, List<string>> ValidateBattery(Dictionary<string, string> batteryFields)
        {
            Dictionary<bool, List<string>> result = new Dictionary<bool, List<string>>();
            bool output = true;
            List<string> errorsBattery = new List<string>();

            // Box validation
            string batteryBoxNumber = batteryFields["batteryBoxNumber"];
            string batteryBoxPattern = @"^([1-9]+)$";
            if (batteryBoxNumber.Length == 0)
            {
                output = false;
                errorsBattery.Add("Box couldn't be empty");
            }
            if (batteryBoxNumber.Length > 2)
            {
                output = false;
                errorsBattery.Add("Box Length should be <= 2");
            }
            if (!UnitValidationRegex.Validate(batteryBoxNumber, batteryBoxPattern))
            {
                output = false;
                errorsBattery.Add("Wrong Box pattern");
            }

            // SerialOne validation
            if (batteryFields["serialOne"].Length != 0)
            {
                string serialOne = batteryFields["serialOne"];
                string serialOnePattern = @"^(S1-[0-9]{4})-([0-9]{4})$";
                BatteryModel battery = ApiHelpers.ApiConnectorHelper.GetSelectedJobData<BatteryModel>(serialOne, PathBatterySelected).FirstOrDefault();
                if (battery != null)
                {
                    output = false;
                    errorsBattery.Add($"Battery {serialOne} already exists");
                }
                if (serialOne.Length == 0)
                {
                    output = false;
                    errorsBattery.Add("Serial 1 couldn't be empty");
                }
                if (serialOne.Length > 12)
                {
                    output = false;
                    errorsBattery.Add("Serial 1 Length should be = 12");
                }
                if (!UnitValidationRegex.Validate(serialOne, serialOnePattern))
                {
                    output = false;
                    errorsBattery.Add("Wrong Serial 1 pattern");
                }
            }
                

            // CCD validation
            if (batteryFields["batteryCCD"].Length != 0)
            {
                string batteryCCD = batteryFields["batteryCCD"];
                string batteryCcdPattern = @"^([0-9]{8})-([0-9]{6})-([0-9]{7})$";   // 10707090-021017-0013452
                if (batteryCCD.Length == 0)
                {
                    output = false;
                    errorsBattery.Add("CCD couldn't be empty");
                }
                if (batteryCCD.Length > 25)
                {
                    output = false;
                    errorsBattery.Add("CCD Length should be <= 25");
                }
                if (!UnitValidationRegex.Validate(batteryCCD, batteryCcdPattern))
                {
                    output = false;
                    errorsBattery.Add("Wrong CCD pattern");
                }
            }


            // Invoice validation
            if (batteryFields["batteryInvoice"].Length != 0)
            {
                string batteryInvoice = batteryFields["batteryInvoice"];
                string batteryInvoicePattern = @"^([A-Z])\/([0-9]{2})\/([0-9]{2})$";
                if (batteryInvoice.Length == 0)
                {
                    output = false;
                    errorsBattery.Add("Invoice couldn't be empty");
                }
                if (batteryInvoice.Length > 10)
                {
                    output = false;
                    errorsBattery.Add("Invoice Length should be <= 10");
                }
                if (!UnitValidationRegex.Validate(batteryInvoice, batteryInvoicePattern))
                {
                    output = false;
                    errorsBattery.Add("Wrong Invoice pattern");
                }
            }


            // Arrived Date validation
            if (batteryFields["batteryArrived"].Length != 0)
            {
                string batteryArrived = batteryFields["batteryArrived"];
                string batteryArrivedPattern = @"^([0-9]{4})-([0-9]{2}-([0-9]{2}))$";
                if (batteryArrived.Length == 0)
                {
                    output = false;
                    errorsBattery.Add("Arriving date couldn't be empty");
                }
                if (batteryArrived.Length > 10)
                {
                    output = false;
                    errorsBattery.Add("Arriving date Length should be <= 10");
                }
                if (!UnitValidationRegex.Validate(batteryArrived, batteryArrivedPattern))
                {
                    output = false;
                    errorsBattery.Add("Wrong Arriving date pattern");
                }
            }

            // Container validation
            if (batteryFields["batteryContainer"].Length != 0)
            {
                string batteryContainer = batteryFields["batteryContainer"];
                if (batteryContainer.Length > 20)
                {
                    errorsBattery.Add("Container Length should be <= 20");
                }
            }

            result.Add(output, errorsBattery);

            return result;
        }
    }
}