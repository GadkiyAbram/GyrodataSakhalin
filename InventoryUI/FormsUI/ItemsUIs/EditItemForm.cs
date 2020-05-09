using InventoryLibrary;
using InventoryLibrary.Validation.ToolValidation;
using InventoryUI.ApiHelpers;
using InventoryUI.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryUI.FormsUI.ItemsUIs
{
    public partial class EditItemForm : Form
    {
        string imgLocation = null;
        string pathItemsCustom = "PathItemsCustom";
        string pathItemsEdit = "PathItemsEdit";
        public List<string> errorsItem = new List<string>();
        int item_id = 0;
        List<string> output = new List<string>();
        string item = "";
        string asset = "";

        public EditItemForm(List<ItemModel> itemList)
        {
            InitializeComponent();
            LoadAllItemsToComboBox(itemList);
            //LoadSelectedItem(item, asset);
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

        public Image stringToImage(string inputString)
        {
            byte[] NewBytes = Convert.FromBase64String(inputString);
            MemoryStream ms1 = new MemoryStream(NewBytes);
            Image NewImage = Image.FromStream(ms1);

            return NewImage;
        }

        private void LoadSelectedItem(string item, string asset)
        {
            // Add default data to IMAGE
            pictureBoxEditItem.Image = null;
            // start refactor here
            ItemModel itemModel = ApiHelpers.ApiConnectorHelper.CustomDataLoad<ItemModel>(item, asset, pathItemsCustom).First();
            item_id = itemModel.Id;

            editItemItemText.Text = itemModel.Item;
            editItemAssetText.Text = itemModel.Asset;
            editItemArrivedText.Text = itemModel.Arrived;
            editItemInvoiceText.Text = itemModel.Invoice;
            editItemCcdText.Text = itemModel.CCD;
            editItemPositionCcdText.Text = itemModel.PositionCCD;
            editItemStatusText.Text = itemModel.ItemStatus;

            if (itemModel.ItemImage != null) 
            {
                //pictureBoxEditItem.Image = null;
                pictureBoxEditItem.Image = stringToImage(itemModel.ItemImage);
            }

            // TODO - Refactor this, move to the ItemModel
            if (itemModel.Item == "GDP Sections" || itemModel.Item == "GWD Modem" || itemModel.Item == "GWD Bullplug")
            {
                editItemCirculationText.Text = itemModel.Circulation.ToString();
            }
            else
            {
                editItemCirculationText.Text = "N/A";
            }

            editItemNameRusText.Text = itemModel.NameRus;
            editItemBoxText.Text = itemModel.Box;
            editItemContainerText.Text = itemModel.Container;
            editItemCommentText.Text = itemModel.Comment;
        }

        private byte[] GetItemImage()
        {
            byte[] itemImage = null;
            if (imgLocation != "")
            {
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                itemImage = brs.ReadBytes((int)stream.Length);
            }
            return itemImage;
        }

        private void editItemButton_Click(object sender, EventArgs e)
        {
            string convertedImage = ImageClass.prepareImageToString(imgLocation);

            if (ValidateForm().Keys.First())
            {
                ItemModel model = new ItemModel(
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
                    editItemCommentText.Text,
                    convertedImage
                    );

                ApiHelpers.ApiConnectorHelper.EditData<ItemModel>(item_id.ToString(), model, pathItemsEdit);
            }
            else
            {
                ErrorForm errorForm = new ErrorForm(ValidateForm().Values.First());
                errorForm.Show();
            }
        }

        private Dictionary<bool, List<string>> ValidateForm()
        {
            Dictionary<string, string> itemFields = new Dictionary<string, string>();
            itemFields.Add("itemItem", selectItemComboBox.Text);
            itemFields.Add("itemAsset", editItemAssetText.Text);
            itemFields.Add("itemArrived", editItemArrivedText.Text);
            itemFields.Add("itemInvoice", editItemInvoiceText.Text);
            itemFields.Add("itemCCD", editItemCcdText.Text);
            itemFields.Add("itemPosition", editItemPositionCcdText.Text);
            itemFields.Add("itemStatus", editItemStatusText.Text);
            itemFields.Add("itemContainer", editItemContainerText.Text);

            var output = ItemValidation.ValidateItem(itemFields);

            return output;
        }

        private void browseImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*jpg|png files(*.png)|*.png|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBoxEditItem.ImageLocation = imgLocation;
            }
        }

        //private bool ValidateForm()
        //{
        //    // TODO - check if Item already exists
        //    bool output = true;
        //    errorsItem.Clear();

        //    // Item validation - no need as the GWD Items List fixed

        //    // asset validation
        //    if (editItemAssetText.Text.Length > 20)
        //    {
        //        output = false;
        //        errorsItem.Add("Asset Length should be <= 20");
        //    }

        //    // Arrived validation
        //    DateValidation dateValidation = new DateValidation(editItemArrivedText.Text);
        //    if (editItemArrivedText.Text.Length == 0)
        //    {
        //        output = false;
        //        errorsItem.Add("Date couldn't be empty");
        //    }
        //    if (editItemArrivedText.Text.Length > 10)
        //    {
        //        output = false;
        //        errorsItem.Add("Date Length should be 10 simbols");
        //    }
        //    if (!dateValidation.ValidateDate())
        //    {
        //        output = false;
        //        errorsItem.Add("Wrong Date pattern");
        //    }

        //    // Invoice validation
        //    InvoiceValidation invoiceValidation = new InvoiceValidation(editItemInvoiceText.Text);
        //    if (editItemInvoiceText.Text.Length == 0)
        //    {
        //        output = false;
        //        errorsItem.Add("Invoice couldn't be empty");
        //    }
        //    if (editItemInvoiceText.Text.Length > 10)
        //    {
        //        output = false;
        //        errorsItem.Add("Invoice Length should be <= 10");
        //    }
        //    if (!invoiceValidation.ValidateInvoice())
        //    {
        //        output = false;
        //        errorsItem.Add("Wrong Invoice pattern, should be like X/MM/YY");
        //    }

        //    // ccd validation
        //    CCDValidation ccdValidation = new CCDValidation(editItemCcdText.Text);
        //    if (editItemCcdText.Text.Length == 0)
        //    {
        //        output = false;
        //        errorsItem.Add("CCD couldn't be empty");
        //    }
        //    if (editItemCcdText.Text.Length > 25)
        //    {
        //        output = false;
        //        errorsItem.Add("CCD Length should be <= 25");
        //    }
        //    if (!ccdValidation.ValidateCCD())
        //    {
        //        output = false;
        //        errorsItem.Add("Wrong CCD pattern");
        //    }

        //    // positionCCD validation
        //    int positionInCCD = 0;
        //    bool positionrValidNumber = int.TryParse(editItemPositionCcdText.Text, out positionInCCD);
        //    if (editItemPositionCcdText.Text.Length > 2)
        //    {
        //        output = false;
        //        errorsItem.Add("Position is Too long, should be <= 2");
        //    }
        //    if (positionrValidNumber == false)
        //    {
        //        output = false;
        //        errorsItem.Add("Wrong Position number");
        //    }

        //    // status validation
        //    if (editItemStatusText.Text.Length > 20)
        //    {
        //        output = false;
        //        errorsItem.Add("Item Status is Tool long, should be <= 20");
        //    }

        //    // container validation
        //    if (editItemContainerText.Text.Length > 10)
        //    {
        //        output = false;
        //        errorsItem.Add("Container Name Too long");
        //    }

        //    return output;
        //}
    }
}
