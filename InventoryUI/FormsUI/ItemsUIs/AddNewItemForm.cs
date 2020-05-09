using InventoryLibrary;
using InventoryLibrary.Extras;
using InventoryLibrary.Validation.ToolValidation;
using InventoryUI.ApiHelpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryUI
{
    public partial class AddNewItemForm : Form
    {
        // TODO - refactor path accordingly
        string pathItemsAdd = "PathItemsAdd";
        string pathItemsAddWithImage = "PathItemsAddWithImage";
        string imgLocation = "";
        public List<string> errorsItem = new List<string>();

        public AddNewItemForm()
        {
            // TODO - refactor CCD / Invoice insertion, as combobox. Load from Enum
            InitializeComponent();
            ExtraFunctions.LoadGWDItemsToComboBox(itemItemText);
            ExtraFunctions.LoadStoringToComboBox(itemBoxText);
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            string convertedImage = ImageClass.prepareImageToString(imgLocation);

            int result = 0;
            if (ValidateForm())
            {
                ItemModel model = new ItemModel(
                itemItemText.Text,          // check length, pattern
                itemAssetText.Text,         // check length
                itemArrivedText.Text,       // check length, pattern
                itemInvoiceText.Text,       // check length, pattern

                // TODO - complete CCD, NameRus and all below
                itemCcdText.Text,           // check length, pattern
                itemNameRusText.Text,
                itemPositionCcdText.Text,   // check length, pattern
                itemStatusText.Text,        // check length
                itemBoxText.Text,           // check length
                itemContainerText.Text,     // check length
                itemCommentText.Text,           // check length
                convertedImage
                );

                //MessageBox.Show(BitConverter.ToString(model.ItemImage).Replace("-", ""));
                result = ApiHelpers.ApiConnectorHelper.SaveData<ItemModel>(model, pathItemsAdd);
                if (result != 0)
                {
                    MessageBox.Show($"{ itemItemText.Text } { itemAssetText.Text } added");
                }
                else
                {
                    MessageBox.Show("Smth went wrong");
                }

            }
            else
            {
                ErrorForm errorForm = new ErrorForm(errorsItem);
                errorForm.Show();
            }
        }

        private bool ValidateForm()
        {
            // TODO - check if Item already exists
            bool output = true;
            errorsItem.Clear();

            // Item validation - check if exists one already
            //if (SqlConnector.CheckIfItemExists(itemItemText.Text, itemAssetText.Text).Count != 0)
            //{
            //    output = false;
            //    errorsItem.Add($"{ itemItemText.Text } { itemAssetText.Text } already exists");
            //}
            
            // asset validation
            if (itemAssetText.Text.Length > 20)
            {
                output = false;
                errorsItem.Add("Asset Length should be <= 20");
            }

            // Arrived validation
            DateValidation dateValidation = new DateValidation(itemArrivedText.Text);
            if (itemArrivedText.Text.Length == 0)
            {
                output = false;
                errorsItem.Add("Date couldn't be empty");
            }
            if (itemArrivedText.Text.Length > 10)
            {
                output = false;
                errorsItem.Add("Date Length should be 10 simbols");
            }
            if (!dateValidation.ValidateDate())
            {
                output = false;
                errorsItem.Add("Wrong Date pattern");
            }

            // Invoice validation
            InvoiceValidation invoiceValidation = new InvoiceValidation(itemInvoiceText.Text);
            if (itemInvoiceText.Text.Length == 0)
            {
                output = false;
                errorsItem.Add("Invoice couldn't be empty");
            }
            if (itemInvoiceText.Text.Length > 10)
            {
                output = false;
                errorsItem.Add("Invoice Length should be <= 10");
            }
            if (!invoiceValidation.ValidateInvoice())
            {
                output = false;
                errorsItem.Add("Wrong Invoice pattern, should be like X/MM/YY");
            }

            // ccd validation
            CCDValidation ccdValidation = new CCDValidation(itemCcdText.Text);
            if (itemCcdText.Text.Length == 0)
            {
                output = false;
                errorsItem.Add("CCD couldn't be empty");
            }
            if (itemCcdText.Text.Length > 25)
            {
                output = false;
                errorsItem.Add("CCD Length should be <= 25");
            }
            if (!ccdValidation.ValidateCCD())
            {
                output = false;
                errorsItem.Add("Wrong CCD pattern");
            }

            // positionCCD validation
            int positionInCCD = 0;
            bool positionrValidNumber = int.TryParse(itemPositionCcdText.Text, out positionInCCD);
            if (positionrValidNumber == false)
            {
                output = false;
                errorsItem.Add("Wrong Position number");
            }

            // status validation
            if (itemStatusText.Text.Length > 20)
            {
                output = false;
                errorsItem.Add("Item Status is Tool long, should be <= 20");
            }

            // container validation
            if (itemContainerText.Text.Length > 10)
            {
                output = false;
                errorsItem.Add("Container Name Too long");
            }

            return output;
        }

        private void browseImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*jpg|png files(*.png)|*.png|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                itemPictureBox.ImageLocation = imgLocation;
            }
        }
    }
}
