using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InventoryLibrary.Validation.BatteryValidation
{
    public class SerialOneValidation
    {
        private string inputString { get; set; }
        private string pattern = @"^(S1-[0-9]{4})-([0-9]{4})$";

        public SerialOneValidation(string itemString)
        {
            this.inputString = itemString;
        }

        public bool ValidateSerialOne()
        {
            bool output = true;

            Match match = Regex.Match(this.inputString, pattern);

            if (!match.Success)
            {
                return false;
            }

            return output;
        }
    }
}
