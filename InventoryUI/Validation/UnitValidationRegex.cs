using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InventoryUI.Validation
{
    public class UnitValidationRegex
    {
        public static bool Validate(string unit, string pattern)
        {
            bool output = true;

            Match match = Regex.Match(unit, pattern);

            if (!match.Success)
            {
                return false;
            }

            return output;
        }
    }
}