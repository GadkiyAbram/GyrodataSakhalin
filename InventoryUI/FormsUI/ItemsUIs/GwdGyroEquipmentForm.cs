using InventoryLibrary;
using InventoryUI.FormsUI.ItemsUIs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Services;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryUI
{
    public partial class GwdGyroEquipmentForm : Form
    {
        List<ItemModel> itemList = new List<ItemModel>();

        public GwdGyroEquipmentForm()
        {
            InitializeComponent();
            GwdGyroCustomItemsLoad("", "");
            //TODO - remove getallequipment
            //GwdGyroAllItemsLoad();
        }

        private void AddNewItemLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewItemForm addNewItem = new AddNewItemForm();
            addNewItem.Show();
        }

        //TODO - remove getallequipment function
        private List<ItemModel> GwdGyroAllItemsLoad()
        {
            return SqlConnector.GetEquipmentData();

        }

        private void GwdGyroCustomItemsLoad(string what, string where)
        {
            gwdGyroGridView.DataSource = SqlConnector.GetCustomEquipmentData(what, where);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            switch (searchItemComboBox.Text)
            {
                case "Item":
                    GwdGyroCustomItemsLoad(searchItemText.Text, "Item");
                    break;
                case "Asset":
                    GwdGyroCustomItemsLoad(searchItemText.Text, "Asset");
                    break;
                case "CCD":
                    GwdGyroCustomItemsLoad(searchItemText.Text, "CCD");
                    break;
                case "Invoice":
                    GwdGyroCustomItemsLoad(searchItemText.Text, "Invoice");
                    break;
                case "":
                    GwdGyroCustomItemsLoad("", "");
                    //TODO - remove getallequipment
                    //GwdGyroAllItemsLoad();
                    break;
            }
        }

        private void checkItemLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            itemList = GwdGyroAllItemsLoad();
            EditItemForm editItemForm = new EditItemForm(itemList);
            editItemForm.Show();
        }
    }
}
