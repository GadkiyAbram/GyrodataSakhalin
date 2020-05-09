using InventoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryUI.Validation
{
    public class ItemValidation
    {
        static string PathItemSelected = "PathItemsCustom";
        public static Dictionary<bool, List<string>> ValidateItem(Dictionary<string, string> itemFields)
        {
            Dictionary<bool, List<string>> result = new Dictionary<bool, List<string>>();
            bool output = true;
            List<string> errorsItem = new List<string>();

            // No need in Item Name validation AS it's strict in list
            // Asset validation
            string itemAsset = null;
            if (itemFields["itemAsset"].Length != 0)
            {
                itemAsset = itemFields["itemAsset"];
                if (itemAsset.Length > 20)
                {
                    output = false;
                    errorsItem.Add("Asset Length should be <= 20");
                }
            }

            if (itemFields.Keys.Contains(itemFields["itemItem"]))
            {
                ItemModel item = ApiHelpers.ApiConnectorHelper.CustomDataLoad<ItemModel>(itemFields["itemItem"], itemAsset, PathItemSelected).FirstOrDefault();
                if (item != null)
                {
                    output = false;
                    errorsItem.Add($"{ item.Item } {item.Asset} already exists");
                }
            }

            // Arrived Date validation
            if (itemFields["itemArrived"].Length != 0)
            {
                string itemArrived = itemFields["itemArrived"];
                string itemArrivedPattern = @"^([0-9]{4})-([0-9]{2}-([0-9]{2}))$";
                if (itemArrived.Length == 0)
                {
                    output = false;
                    errorsItem.Add("Arriving date couldn't be empty");
                }
                if (itemArrived.Length > 10)
                {
                    output = false;
                    errorsItem.Add("Arriving date Length should be <= 10");
                }
                if (!UnitValidationRegex.Validate(itemArrived, itemArrivedPattern))
                {
                    output = false;
                    errorsItem.Add("Wrong Arriving date pattern");
                }
            }

            // Invoice validation
            if (itemFields["itemInvoice"].Length != 0)
            {
                string itemInvoice = itemFields["itemInvoice"];
                string itemInvoicePattern = @"^([A-Z])\/([0-9]{2})\/([0-9]{2})$";
                if (itemInvoice.Length == 0)
                {
                    output = false;
                    errorsItem.Add("Invoice couldn't be empty");
                }
                if (itemInvoice.Length > 10)
                {
                    output = false;
                    errorsItem.Add("Invoice Length should be <= 10");
                }
                if (!UnitValidationRegex.Validate(itemInvoice, itemInvoicePattern))
                {
                    output = false;
                    errorsItem.Add("Wrong Invoice pattern");
                }
            }

            // CCD validation
            if (itemFields["itemCCD"].Length != 0)
            {
                string itemCCD = itemFields["itemCCD"];
                string itemCcdPattern = @"^([0-9]{8})-([0-9]{6})-([0-9]{7})$";   // 10707090-021017-0013452
                if (itemCCD.Length == 0)
                {
                    output = false;
                    errorsItem.Add("CCD couldn't be empty");
                }
                if (itemCCD.Length > 25)
                {
                    output = false;
                    errorsItem.Add("CCD Length should be <= 25");
                }
                if (!UnitValidationRegex.Validate(itemCCD, itemCcdPattern))
                {
                    output = false;
                    errorsItem.Add("Wrong CCD pattern");
                }
            }

            // positionCCD validation
            if (itemFields["itemPosition"].Length != 0)
            {
                int positionInCCD = 0;
                string itemPosition = itemFields["itemPosition"];
                bool positionrValidNumber = int.TryParse(itemPosition, out positionInCCD);
                if (itemPosition.Length > 2)
                {
                    output = false;
                    errorsItem.Add("Position is Too long, should be <= 2");
                }
                if (positionrValidNumber == false)
                {
                    output = false;
                    errorsItem.Add("Wrong Position number");
                }
            }
            
            // Status (Location) validation
            if (itemFields["itemStatus"].Length != 0)
            {
                string itemStatus = itemFields["itemStatus"];
                if (itemStatus.Length > 20)
                {
                    errorsItem.Add("Location Length should be <= 20");
                }
            }

            // Container validation
            if (itemFields["itemContainer"].Length != 0)
            {
                string itemContainer = itemFields["itemContainer"];
                if (itemContainer.Length > 20)
                {
                    errorsItem.Add("Container Length should be <= 20");
                }
            }

            result.Add(output, errorsItem);

            return result;
        }
    }
}
