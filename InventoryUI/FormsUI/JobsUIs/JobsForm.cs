using InventoryLibrary;
using InventoryUI.ApiHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Windows.Forms;

namespace InventoryUI.FormsUI.JobsUIs
{
    public partial class JobsForm : Form
    {
        string pathJobsAll = "PathJobsAll";
        public static int countJobsInstance = 0;

        public JobsForm()
        {
            InitializeComponent();
            countJobsInstance++;
            JobCustomLoad("", "", pathJobsAll);
            searchJobComboBox.SelectedIndex = 0;
        }

        private void AddNewJobLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewJobForm addNewJob = new AddNewJobForm();
            addNewJob.Show();
        }

        private void editJobsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<JobModel> jobList = ApiConnectorHelper.DataLoad<JobModel>("", "", pathJobsAll);
            EditJobForm editJobForm = new EditJobForm(jobList);
            editJobForm.Show();
        }

        private void JobCustomLoad(string what, string where, string path)
        {
            jobsGridView.DataSource = ApiConnectorHelper.DataLoad<JobModel>(what, where, path);
        }

        private void refreshJobButton_Click(object sender, EventArgs e)
        {
            getSelectedJobData();
        }

        private void getSelectedJobData()
        {
            string searchJob = searchJobText.Text;
            string searchItemComboBox = searchJobComboBox.Text;

            JobCustomLoad(searchJob, searchItemComboBox, pathJobsAll);
        }

        private void JobsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            countJobsInstance = 0;
        }
    }
}
