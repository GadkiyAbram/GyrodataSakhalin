using InventoryLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryUI.FormsUI.JobsUIs
{
    public partial class JobsForm : Form
    {
        List<JobModel> jobList = new List<JobModel>();

        public JobsForm()
        {
            InitializeComponent();
            JobCustomLoad("", "");
        }

        private void AddNewJobLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewJobForm addNewJob = new AddNewJobForm();
            addNewJob.Show();
        }

        private void editJobsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            jobList = LoadAllJobsToComboBox();
            EditJobForm editJobForm = new EditJobForm(jobList);
            editJobForm.Show();
        }

        private List<JobModel> LoadAllJobsToComboBox()
        {
            return SqlConnector.GetAllJobsData();
        }

        // TODO - Check if you need this
        private void LoadAllJobsData()
        {
            jobsGridView.DataSource = SqlConnector.GetAllJobsData();
        }

        private void JobCustomLoad(string what, string where)
        {
            jobsGridView.DataSource = SqlConnector.GetCustomJobData(what, where);
        }

        private void refreshJobButton_Click(object sender, EventArgs e)
        {
            string searchJob = searchJobText.Text;
            switch (searchJobComboBox.Text)
            {
                case "GDP Sections":
                    JobCustomLoad(searchJob, "GDP Sections");
                    break;
                case "Job Number":
                    JobCustomLoad(searchJob, "Job Number");
                    break;
                case "Modem":
                    JobCustomLoad(searchJob, "Modem");
                    break;
                case "Bullplug":
                    JobCustomLoad(searchJob, "Bullplug");
                    break;
                case "Battery":
                    JobCustomLoad(searchJob, "Battery");
                    break;
                case "":
                    JobCustomLoad("", "");
                    break;
            }
        }
    }
}
