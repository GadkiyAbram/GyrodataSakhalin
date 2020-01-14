﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace InventoryLibrary.Validation.ToolValidation
{
    public class InvoiceValidation
    {
        private string inputString { get; set; }
        private string pattern = @"^([A-Z])\/([0-9]{2})\/([0-9]{2})$";

        public InvoiceValidation(string itemString)
        {
            this.inputString = itemString;
        }

        public bool ValidateInvoice()
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
