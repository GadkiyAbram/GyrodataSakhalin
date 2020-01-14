using InventoryLibrary;
using InventoryLibrary.Validation.ToolValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryUI.FormsUI.ItemsUIs
{
    public partial class EditItemForm : Form
    {
        public List<string> errorsItem = new List<string>();
        int item_id = 0;
        List<string> output = new List<string>();
        string item = "";
        string asset = "";

        public EditItemForm(List<ItemModel> itemList)
        {
            InitializeComponent();
            LoadAllItemsToComboBox(itemList);
            LoadSelectedItem(item, asset);
        }

        private void LoadAllItemsToComboBox(List<ItemModel> itemList)
        {
            // TODO - check if the jobList is NULL
            foreach (var item in itemList)
            {
                selectItemComboBox.Items.Add(item.Item + "    " + item.Asset);
            }
            selectItemComboBox.SelectedIndex = 0;

        }

        private void selectItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            item = "";
            asset = "";
            output = splitItemAndAssetInComboBox(selectItemComboBox.Text);
            item = output.ElementAt(0);
            asset = output.ElementAt(1);
            LoadSelectedItem(item, asset);
        }

        private List<string> splitItemAndAssetInComboBox(string itemTextToSplit)
        {
            
            output = itemTextToSplit.Split(new string[] { "    " }, StringSplitOptions.None).ToList();
            //MessageBox.Show(output.ElementAt(0) + " " + output.ElementAt(1));
            //item = output.ElementAt(0);
            //asset = output.ElementAt(1);
            return output;
        }

        private void LoadSelectedItem(string item, string asset)
        {
            ItemModel itemModel = SqlConnector.GetSelectedItem(item, asset).First();
            item_id = itemModel.Id;

            editItemItemText.Text = itemModel.Item;
            editItemAssetText.Text = itemModel.Asset;
            editItemArrivedText.Text = itemModel.Arrived;
            editItemInvoiceText.Text = itemModel.Invoice;
            editItemCcdText.Text = itemModel.CCD;
            editItemPositionCcdText.Text = itemModel.PositionInCCD;
            editItemStatusText.Text = itemModel.ItemStatus;

            // TODO - Refactor this, move to the ItemModel
            if (itemModel.Item == "GDP Sections" || itemModel.Item == "GWD Modem" || itemModel.Item == "GWD Bullplug")
            {
                editItemCirculationText.Text = itemModel.Circulation.ToString();
            }
            else
            {
                editItemCirculationText.Text = "N/A";
            }

            editItemNameRusText.Text = itemModel.NameRussian;
            editItemBoxText.Text = itemModel.Box;
            editItemContainerText.Text = itemModel.Container;
            editItemCommentText.Text = itemModel.Comment;

            


        }

        private bool ValidateForm()
        {
            // TODO - check if Item already exists
            bool output = true;
            errorsItem.Clear();

            // Item validation - no need as the GWD Items List fixed

            // asset validation
            if (editItemAssetText.Text.Length > 20)
            {
                output = false;
                errorsItem.Add("Asset Length should be <= 20");
            }

            // Arrived validation
            DateValidation dateValidation = new DateValidation(editItemArrivedText.Text);
            if (editItemArrivedText.Text.Length == 0)
            {
                output = false;
                errorsItem.Add("Date couldn't be empty");
            }
            if (editItemArrivedText.Text.Length > 10)
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
            InvoiceValidation invoiceValidation = new InvoiceValidation(editItemInvoiceText.Text);
            if (editItemInvoiceText.Text.Length == 0)
            {
                output = false;
                errorsItem.Add("Invoice couldn't be empty");
            }
            if (editItemInvoiceText.Text.Length > 10)
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
            CCDValidation ccdValidation = new CCDValidation(editItemCcdText.Text);
            if (editItemCcdText.Text.Length == 0)
            {
                output = false;
                errorsItem.Add("CCD couldn't be empty");
            }
            if (editItemCcdText.Text.Length > 25)
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
            bool positionrValidNumber = int.TryParse(editItemPositionCcdText.Text, out positionInCCD);
            if (editItemPositionCcdText.Text.Length > 2)
            {
                output = false;
                errorsItem.Add("Position is Too long, should be <= 2");
            }
            if (positionrValidNumber == false)
            {
                output = false;
                errorsItem.Add("Wrong Position number");
            }

            // status validation
            if (editItemStatusText.Text.Length > 20)
            {
                output = false;
                errorsItem.Add("Item Status is Tool long, should be <= 20");
            }

            // container validation
            if (editItemContainerText.Text.Length > 10)
            {
                output = false;
                errorsItem.Add("Container Name Too long");
            }

            return output;
        }

        private void editItemButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ItemModel itemModel = new ItemModel(
                    editItemItemText.Text,
                    editItemAssetText.Text,
                    editItemArrivedText.Text,
                    editItemInvoiceText.Text,
                    editItemCcdText.Text,
                    editItemNameRusText.Text,
                    editItemPositionCcdText.Text,
                    editItemStatusText.Text,
                    editItemBoxText.Text,
                    editItemContainerText.Text,
                    editItemCommentText.Text
                    );

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.UpdateItem(item_id, itemModel);
                }
                MessageBox.Show($"{ itemModel.Item } corrected");
            }
            else
            {
                ErrorForm errorForm = new ErrorForm(errorsItem);
                errorForm.Show();
            }
        }
    }
}
