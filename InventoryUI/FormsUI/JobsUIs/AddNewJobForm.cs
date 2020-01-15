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
using InventoryLibrary.Validation.ToolValidation;

namespace InventoryUI.FormsUI.JobsUIs
{
    public partial class AddNewJobForm : Form
    {
        public List<string> errorsAddJob = new List<string>();

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
            jobEngOneComboBox.SelectedIndex = 8;
            jobEngTwoComboBox.SelectedIndex = 8;
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
                ErrorForm errorForm = new ErrorForm(errorsAddJob);
                errorForm.Show();
            }
        }

        // TODO - Complete Job's validation
        private bool ValidateForm()
        {
            // TODO - check if Item already exists
            bool output = true;
            errorsAddJob.Clear();

            // JobNumber validation
            JobNumberValidation jobValidation = new JobNumberValidation(jobNumberText.Text);
            if (jobNumberText.Text == null)
            {
                output = false;
                errorsAddJob.Add("Job Number couldn't be empty");
            }
            if (jobNumberText.Text.Length > 12)
            {
                output = false;
                errorsAddJob.Add("Job Number Length should be <= 12");
            }
            if (!jobValidation.ValidateItem())
            {
                output = false;
                errorsAddJob.Add("Wrong Job Number pattern");
            }

            // Circulation validating
            if (jobCirculationHoursText.Text.Length != 0)
            {
                float circulation = 0;
                bool ValidateCirculation = float.TryParse(jobCirculationHoursText.Text, out circulation);
                if (!ValidateCirculation)
                {
                    output = false;
                    errorsAddJob.Add("Wrong Circulation value");
                }
            }

            // Enginners validation. Not one to be selected as both engs
            // N/A COULD BE selected for both
            if (jobEngOneComboBox.SelectedIndex != 8 && jobEngTwoComboBox.SelectedIndex != 8)
            {
                if (jobEngOneComboBox.Text == jobEngTwoComboBox.Text)
                {
                    output = false;
                    errorsAddJob.Add("One Engineer can not be selected as both");
                }
            }
            

            // MaxTemperature validating
            if (jobMaxTemperatureText.Text.Length != 0)
            {
                float maxTemperature = 0;
                bool ValidateMaxTemperature = float.TryParse(jobMaxTemperatureText.Text, out maxTemperature);
                if (!ValidateMaxTemperature)
                {
                    output = false;
                    errorsAddJob.Add("Wrong Max Temperature value");
                }
            }

            // Dates validating, Engs Arrvied / Left, Container Arr / Left
            DateValidation dateEng1ArrivedValidation = new DateValidation(jobEng1ArrivedText.Text);
            if (jobEng1ArrivedText.Text.Length > 0)
            {
                if (!dateEng1ArrivedValidation.ValidateDate())
                {
                    output = false;
                    errorsAddJob.Add("Arrived Eng1 Date invalid");
                }
            }

            DateValidation dateEng2ArrivedValidation = new DateValidation(jobEng2ArrivedText.Text);
            if (jobEng2ArrivedText.Text.Length > 0)
            {
                if (!dateEng2ArrivedValidation.ValidateDate())
                {
                    output = false;
                    errorsAddJob.Add("Arrived Eng2 Date invalid");
                }
            }

            DateValidation dateEng1LeftValidation = new DateValidation(jobEng1LeftText.Text);
            if (jobEng1LeftText.Text.Length > 0)
            {
                if (!dateEng1LeftValidation.ValidateDate())
                {
                    output = false;
                    errorsAddJob.Add("Left Eng1 Date invalid");
                }
            }

            DateValidation dateEng2LeftValidation = new DateValidation(jobEng2LeftText.Text);
            if (jobEng2LeftText.Text.Length > 0)
            {
                if (!dateEng2LeftValidation.ValidateDate())
                {
                    output = false;
                    errorsAddJob.Add("Left Eng2 Date invalid");
                }
            }

            DateValidation dateContainerArrValidation = new DateValidation(jobContArrivedText.Text);
            if (jobContArrivedText.Text.Length > 0)
            {
                if (!dateContainerArrValidation.ValidateDate())
                {
                    output = false;
                    errorsAddJob.Add("Container Arrived Date invalid");
                }
            }

            DateValidation dateContainerLeftValidation = new DateValidation(jobContLeftText.Text);
            if (jobContLeftText.Text.Length > 0)
            {
                if (!dateContainerLeftValidation.ValidateDate())
                {
                    output = false;
                    errorsAddJob.Add("Container Left Date invalid");
                }
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
