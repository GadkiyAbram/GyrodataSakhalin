using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryUI
{
    public partial class ErrorForm : Form
    {
        public ErrorForm(List<string> errors)
        {
            InitializeComponent();

            foreach (string error in errors)
            {
                ErrorsDescription.Text += error + '\n';
            }
        }

        private void OkToCorrectButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
