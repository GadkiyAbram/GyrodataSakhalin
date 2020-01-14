using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InventoryLibrary.Validation.ToolValidation
{
    public class CCDValidation
    {
        private string inputString { get; set; }
        private string pattern = @"^([0-9]{8})-([0-9]{6})-([0-9]{7})$";

        public CCDValidation(string itemString)
        {
            this.inputString = itemString;
        }

        public bool ValidateCCD()
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
