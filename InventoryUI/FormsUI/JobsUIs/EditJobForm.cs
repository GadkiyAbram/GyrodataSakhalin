using InventoryLibrary;
using InventoryLibrary.Validation.ToolValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryUI.FormsUI.JobsUIs
{
    public partial class EditJobForm : Form
    {
        List<string> errorsEditJob = new List<string>();
        // TODO - refactor oldJobCIrculation
        float oldJobCircultaionHours = 0;
        int job_id = 0;

        public EditJobForm(List<JobModel> jobList)
        {
            InitializeComponent();
            LoadAllJobsToComboBox(jobList);
        }

        private void LoadAllJobsToComboBox(List<JobModel> jobList)
        {
            // TODO - check if the jobList is NULL
            foreach (var job in jobList)
            {
                selectJobComboBox.Items.Add(job.JobNumber);
            }
            selectJobComboBox.SelectedIndex = 0;

        }

        // TODO - Complete editing job using ComboBox
        private void selectJobComboBox_SelectedIndexChanged(object sender, EventArgs exception)
        {
            LoadFormWithJobFromComboBox(selectJobComboBox.Text);
        }

        private void LoadFormWithJobFromComboBox(string selectedJob)
        {
            try
            {
                JobModel jobModel = SqlConnector.GetSelectedJob(selectedJob).First();
                job_id = jobModel.Id;

                oldJobCircultaionHours = jobModel.CirculationHours;
                // TODO - Complete displaying Job data

                editJobLabel.Text = jobModel.JobNumber;
                editJobNumberText.Text = jobModel.JobNumber;
                editJobClientText.Text = jobModel.ClientName;
                editJobGdpText.Text = jobModel.Gdp;
                editJobModemText.Text = jobModel.Modem;
                editJobModemVersionText.Text = jobModel.ModemVersion;
                editJobBbpText.Text = jobModel.Bullplug;
                editJobCirculationHoursText.Text = jobModel.CirculationHours.ToString();
                editJobMaxTemperatureText.Text = jobModel.MaxTemp.ToString();
                editJobBatteryText.Text = jobModel.Battery;

                editJobEngOneText.Text = jobModel.EngineerOne;
                editJobEngTwoText.Text = jobModel.EngineerTwo;
                editJobEng1ArrivedText.Text = jobModel.EngineerOneArrived;
                editJobEng2ArrivedText.Text = jobModel.EngineerTwoArrived;
                editJobEng1LeftText.Text = jobModel.EngineerOneLeft;
                editJobEng2LeftText.Text = jobModel.EngineerTwoLeft;

                editJobContainerText.Text = jobModel.Container;
                editJobContArrivedText.Text = jobModel.ContainerArrived;
                editJobContLeftText.Text = jobModel.ContainerLeft;

                editJobRigText.Text = jobModel.Rig;
                // TODO - refactor combobox to appropriate format

                editJobCommentText.Text = jobModel.Comment;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void editJobButton_Click(object sender, EventArgs e)
        {
            if (ValidateEditJob())
            {
                float circul = 0;
                float maxTemp = 0;

                if (editJobCirculationHoursText.Text.Length != 0) { circul = float.Parse(editJobCirculationHoursText.Text); }
                if (editJobMaxTemperatureText.Text.Length != 0) { maxTemp = float.Parse(editJobMaxTemperatureText.Text); }

                JobModel model = new JobModel(
                    editJobNumberText.Text,
                    editJobClientText.Text,
                    editJobGdpText.Text,
                    editJobModemText.Text,
                    editJobModemVersionText.Text,
                    editJobBbpText.Text,
                    circul,
                    //editJobCirculationHoursText.Text,                             // check length, float
                    editJobBatteryText.Text,
                    maxTemp,
                    //editJobMaxTemperatureText.Text,                            // check length, float
                    editJobEngOneText.Text,
                    editJobEngTwoText.Text,
                    editJobEng1ArrivedText.Text,        // length, check date
                    editJobEng2ArrivedText.Text,        // length, check date
                    editJobEng1LeftText.Text,           // length, check date
                    editJobEng2LeftText.Text,           // length, check date
                    editJobContainerText.Text,          // length
                    editJobContArrivedText.Text,        // length, check date
                    editJobContLeftText.Text,           // length, check date
                    editJobRigText.Text,                // length
                    editJbIssuesComboBox.Text,
                    editJobCommentText.Text
                    );

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.UpdateJob(job_id, model, oldJobCircultaionHours);
                }
                MessageBox.Show($"Job { model.JobNumber } corrected");
            }
            else
            {
                ErrorForm errorForm = new ErrorForm(errorsEditJob);
                errorForm.Show();
            }
        }

        private bool ValidateEditJob()
        {
            bool output = true;
            errorsEditJob.Clear();

            // ModemVersion validating
            //if (editJobModemText.Text.Length != 0)
            //{
            //    output = false;
            //    errorsEditJob.Add("Modem Version is empty");
            //}

            // Circulation validating
            if (editJobCirculationHoursText.Text.Length != 0)
            {
                float circulation = 0;
                bool ValidateCirculation = float.TryParse(editJobCirculationHoursText.Text, out circulation);
                if (!ValidateCirculation)
                {
                    output = false;
                    errorsEditJob.Add("Wrong Circulation value");
                }
            }

            // MaxTemperature validating
            if (editJobMaxTemperatureText.Text.Length != 0)
            {
                float maxTemperature = 0;
                bool ValidateMaxTemperature = float.TryParse(editJobMaxTemperatureText.Text, out maxTemperature);
                if (!ValidateMaxTemperature)
                {
                    output = false;
                    errorsEditJob.Add("Wrong Max Temperature value");
                }
            }
            
            // Dates validating
            DateValidation dateEng1ArrivedValidation = new DateValidation(editJobEng1ArrivedText.Text);
            if (editJobEng1ArrivedText.Text.Length > 0)
            {
                if (!dateEng1ArrivedValidation.ValidateDate())
                {
                    output = false;
                    errorsEditJob.Add("Arrived Eng1 Date invalid");
                }
            }

            DateValidation dateEng2ArrivedValidation = new DateValidation(editJobEng2ArrivedText.Text);
            if (editJobEng2ArrivedText.Text.Length > 0)
            {
                if (!dateEng2ArrivedValidation.ValidateDate())
                {
                    output = false;
                    errorsEditJob.Add("Arrived Eng2 Date invalid");
                }
            }

            DateValidation dateEng1LeftValidation = new DateValidation(editJobEng1LeftText.Text);
            if (editJobEng1LeftText.Text.Length > 0)
            {
                if (!dateEng1LeftValidation.ValidateDate())
                {
                    output = false;
                    errorsEditJob.Add("Left Eng1 Date invalid");
                }
            }

            DateValidation dateEng2LeftValidation = new DateValidation(editJobEng2LeftText.Text);
            if (editJobEng2LeftText.Text.Length > 0)
            {
                if (!dateEng2LeftValidation.ValidateDate())
                {
                    output = false;
                    errorsEditJob.Add("Left Eng2 Date invalid");
                }
            }

            DateValidation dateContainerArrValidation = new DateValidation(editJobContArrivedText.Text);
            if (editJobContArrivedText.Text.Length > 0)
            {
                if (!dateContainerArrValidation.ValidateDate())
                {
                    output = false;
                    errorsEditJob.Add("Container Arrived Date invalid");
                }
            }

            DateValidation dateContainerLeftValidation = new DateValidation(editJobContLeftText.Text);
            if (editJobContLeftText.Text.Length > 0)
            {
                if (!dateContainerLeftValidation.ValidateDate())
                {
                    output = false;
                    errorsEditJob.Add("Container Left Date invalid");
                }
            }

            return output;
        }
    }
}
