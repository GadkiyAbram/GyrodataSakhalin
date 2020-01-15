using InventoryLibrary;
using System;
using System.Collections.Generic;
using InventoryLibrary.Validation.JobValidation;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace InventoryUI.FormsUI.JobsUIs
{
    public partial class AddNewJobForm : Form
    {
        public List<string> errorsJob = new List<string>();

        public AddNewJobForm()
        {
            InitializeComponent();
            WireUpComboBoxes();
            jobIssuesComboBox.SelectedIndex = 0;
        }

        public void WireUpComboBoxes()
        {
            LoadAllClientsToComboBox();
            LoadAllGdpToComboBox();
            LoadAllModemsToComboBox();
            LoadAllBbpToComboBox();
            LoadEngineersToComboBox();
            LoadBatteriesToComboBox();
        }

        // TODO - refactor comboboxes
        private void LoadAllClientsToComboBox()
        {
            jobClientComboBox.DataSource = SqlConnector.GetClientsData();
            jobClientComboBox.DisplayMember = "ClientName";
        }

        private void LoadAllGdpToComboBox()
        {
            jobGdpComboBox.DataSource = SqlConnector.GetGdpData();
            jobGdpComboBox.DisplayMember = "Asset";
        }

        private void LoadAllModemsToComboBox()
        {
            jobModemComboBox.DataSource = SqlConnector.GetModemData();
            jobModemComboBox.DisplayMember = "Asset";
        }

        private void LoadAllBbpToComboBox()
        {
            jobBullPlugComboBox.DataSource = SqlConnector.GetBbpData();
            jobBullPlugComboBox.DisplayMember = "Asset";
        }

        private void LoadEngineersToComboBox()
        {
            jobEngOneComboBox.DataSource = SqlConnector.GetEngineerData();
            jobEngTwoComboBox.DataSource = SqlConnector.GetEngineerData();
            jobEngOneComboBox.DisplayMember = "EngineerName";
            jobEngTwoComboBox.DisplayMember = "EngineerName";
        }

        private void LoadBatteriesToComboBox()
        {
            List<BatteryModel> batteriesList = SqlConnector.GetBatteriesData();
            if (batteriesList != null)
            {
                jobBatteryComboBox.DataSource = SqlConnector.GetBatteriesData();
                jobBatteryComboBox.DisplayMember = "SerialOne";
            }
        }

        private float CalculateFloatData(string input)
        {
            float output = 0;
            if (input.Length != 0)
            {
                output = float.Parse(input);
            }

            return output;
        }

        private void addJobButton_Click(object sender, EventArgs e)
        {
            string jobCirculationTime = jobCirculationHoursText.Text;
            string jobMaxTemperature = jobMaxTemperatureText.Text;

            if (ValidateForm())
            {
                JobModel jobModel = new JobModel(
                        jobNumberText.Text,
                        jobClientComboBox.Text,
                        jobGdpComboBox.Text,
                        jobModemComboBox.Text,
                        jobModemVersionText.Text,
                        jobBullPlugComboBox.Text,
                        CalculateFloatData(jobCirculationTime),
                        //jobCirculationHoursText.Text,
                        jobBatteryComboBox.Text,
                        CalculateFloatData(jobMaxTemperature),
                        //jobMaxTemperatureText.Text,
                        jobEngOneComboBox.Text,
                        jobEngTwoComboBox.Text,
                        jobEng1ArrivedText.Text,
                        jobEng2ArrivedText.Text,
                        jobEng1LeftText.Text,
                        jobEng2LeftText.Text,
                        jobContainerText.Text,
                        jobContArrivedText.Text,
                        jobContLeftText.Text,
                        jobRigText.Text,
                        jobIssuesComboBox.Text,
                        jobCommentText.Text
                        );

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreateJob(jobModel);
                }
                //MessageBox.Show($"Job { jobNumberText.Text } added");
                addJobButton.Text = $"Job { jobNumberText.Text } added";
            }
            else
            {
                ErrorForm errorForm = new ErrorForm(errorsJob);
                errorForm.Show();
            }
        }

        // TODO - Complete Job's validation
        private bool ValidateForm()
        {
            // TODO - check if Item already exists
            bool output = true;
            errorsJob.Clear();

            // item validation
            JobNumberValidation jobValidation = new JobNumberValidation(jobNumberText.Text);
            if (jobNumberText.Text == null)
            {
                output = false;
                errorsJob.Add("Job Number couldn't be empty");
            }
            if (jobNumberText.Text.Length > 12)
            {
                output = false;
                errorsJob.Add("Job Number Length should be <= 12");
            }
            if (!jobValidation.ValidateItem())
            {
                output = false;
                errorsJob.Add("Wrong Job Number pattern");
            }

            return output;
        }

        private void AddAnotherJobLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Clearing TextBoxes
            jobNumberText.Text = "";
            jobModemVersionText.Text = "";
            jobCirculationHoursText.Text = "";
            jobMaxTemperatureText.Text = "";
            jobEng1ArrivedText.Text = "";
            jobEng2ArrivedText.Text = "";
            jobEng1LeftText.Text = "";
            jobEng2LeftText.Text = "";
            jobContainerText.Text = "";
            jobContArrivedText.Text = "";
            jobContLeftText.Text = "";
            jobRigText.Text = "";
            jobCommentText.Text = "";
            addJobButton.Text = "ADD JOB";

            // WireUp ComboBoxes
            WireUpComboBoxes();
        }
    }
}
