using InventoryLibrary;
using InventoryUI.ApiHelpers;
using InventoryUI.FormsUI.ItemsUIs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventoryUI
{
    public partial class GwdGyroEquipmentForm : Form
    {
        string pathGwdAll = "PathItemsAll";
        
        public static int countItemsInstance = 0;
        List<ItemModel> itemList = new List<ItemModel>();

        public GwdGyroEquipmentForm()
        {
            InitializeComponent();
            searchItemComboBox.SelectedIndex = 0;
            GwdGyroCustomItemsLoad("", "", pathGwdAll);
            countItemsInstance++;
        }

        private void AddNewItemLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewItemForm addNewItem = new AddNewItemForm();
            addNewItem.Show();
        }

        private void GwdGyroCustomItemsLoad(string what, string where, string path)
        {
            gwdGyroGridView.DataSource = ApiConnectorHelper.DataLoad<ItemModel>(what, where, path);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            string searchItem = searchItemText.Text;
            string itemComboBox = searchItemComboBox.Text;
            GwdGyroCustomItemsLoad(searchItem, itemComboBox, pathGwdAll);
        }

        private void checkItemLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            itemList = ApiConnectorHelper.DataLoad<ItemModel>("", "", pathGwdAll);
            EditItemForm editItemForm = new EditItemForm(itemList);
            editItemForm.Show();
        }

        private void GwdGyroEquipmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            countItemsInstance = 0;
        }
    }
}
