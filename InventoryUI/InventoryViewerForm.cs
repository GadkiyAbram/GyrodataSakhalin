using InventoryUI.FormsUI.JobsUIs;
using InventoryUI.FormsUI.SettingsUI;
using System;
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
            if (GwdGyroEquipmentForm.countItemsInstance == 0)
            {
                GwdGyroEquipmentForm gwdGyroEquipment = new GwdGyroEquipmentForm();
                gwdGyroEquipment.Show(); 
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jobInformationButton_Click(object sender, EventArgs e)
        {
            if (JobsForm.countJobsInstance == 0)
            {
                JobsForm jobsForm = new JobsForm();
                jobsForm.Show();
            }
        }

        private void lithiumBatteriesButton_Click(object sender, EventArgs e)
        {
            if (LithiumBatteriesForm.countLithiumInstance == 0)
            {
                LithiumBatteriesForm lithiumBatteries = new LithiumBatteriesForm();
                lithiumBatteries.Show(); 
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (SettingsForm.countExtrasInstance == 0)
            {
                SettingsForm extras = new SettingsForm();
                extras.Show();
            }
        }
    }
}
