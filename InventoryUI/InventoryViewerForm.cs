using InventoryUI.FormsUI.JobsUIs;
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
    public partial class InventoryViewerForm : Form
    {
        public InventoryViewerForm()
        {
            InitializeComponent();
        }

        private void gwdGyroEquipmentButton_Click(object sender, EventArgs e)
        {
            GwdGyroEquipmentForm gwdGyroEquipment = new GwdGyroEquipmentForm();
            gwdGyroEquipment.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jobInformationButton_Click(object sender, EventArgs e)
        {
            JobsForm jobsForm = new JobsForm();
            jobsForm.Show();
        }

        private void lithiumBatteriesButton_Click(object sender, EventArgs e)
        {
            LithiumBatteriesForm lithiumBatteries = new LithiumBatteriesForm();
            lithiumBatteries.Show();
        }
    }
}
