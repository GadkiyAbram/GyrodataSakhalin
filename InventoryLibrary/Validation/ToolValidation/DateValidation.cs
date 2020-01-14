using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace InventoryLibrary.Validation.ToolValidation
{
    public class DateValidation
    {
        private string inputString { get; set; }
        private string pattern = @"^([0-9]{4})-([0-9]{2}-([0-9]{2}))$";

        public DateValidation(string itemString)
        {
            this.inputString = itemString;
        }

        public bool ValidateDate()
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
