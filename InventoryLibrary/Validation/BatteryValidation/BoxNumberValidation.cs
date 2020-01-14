using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InventoryLibrary.Validation.BatteryValidation
{
    public class BoxNumberValidation
    {
        private string inputString { get; set; }
        private string pattern = @"^([1-9]+)$";

        public BoxNumberValidation(string itemString)
        {
            this.inputString = itemString;
        }

        public bool ValidateBoxNumber()
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
