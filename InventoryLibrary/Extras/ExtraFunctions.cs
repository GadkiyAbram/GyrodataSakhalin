using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryLibrary.Extras
{
    public static class ExtraFunctions
    {
        public static void LoadGWDItemsToComboBox(ComboBox comboBox)
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"CatalogueGWD\\CatalogueGWD.txt");
            while ((line = file.ReadLine()) != null)
            {
                comboBox.Items.Add(line);
            }
            comboBox.SelectedIndex = 0;
            file.Close();
        }

        public static void LoadStoringToComboBox(ComboBox comboBox)
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"CatalogueGWD\\StoringGWD.txt");
            while ((line = file.ReadLine()) != null)
            {
                comboBox.Items.Add(line);
            }
            comboBox.SelectedIndex = 0;
            file.Close();
        }
    }
}
