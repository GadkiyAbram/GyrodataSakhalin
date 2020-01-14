using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InventoryLibrary.Validation.JobValidation
{
    public class JobNumberValidation
    {
        private string inputString { get; set; }
        private string pattern = @"^([A-Z]{2})([0-9]{4})([A-Z]{3})([0-9]{3})$";

        public JobNumberValidation(string itemString)
        {
            this.inputString = itemString;
        }

        public bool ValidateItem()
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
