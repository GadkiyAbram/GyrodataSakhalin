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
                // TODO - Display Engs
                editJobEngOneText.Text = jobModel.EngineerOne;
                editJobEngTwoText.Text = jobModel.EngineerTwo;

                editJobContainerText.Text = jobModel.Container;
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void editJobButton_Click(object sender, EventArgs e)
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
        }

        private bool ValidateEditJob()
        {
            bool output = true;

            // ModemVersion validating
            if (editJobModemText.Text.Length == 0)
            {
                output = false;
                errorsEditJob.Add("Modem Version is empty");
            }

            // Circulation validating
            float circulation = 0;
            bool ValidateCirculation = float.TryParse(editJobCirculationHoursText.Text, out circulation);
            if (editJobCirculationHoursText.Text.Length == 0)
            {
                if (!ValidateCirculation)
                {
                    output = false;
                    errorsEditJob.Add("Wrong Circulation value");
                }
            }

            // MaxTemperature validating
            float maxTemperature = 0;
            bool ValidateMaxTemperature = float.TryParse(editJobMaxTemperatureText.Text, out maxTemperature);
            if (editJobMaxTemperatureText.Text.Length != 0)
            {
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
            DateValidation dateEng1LeftValidation = new DateValidation(editJobEng1LeftText.Text);
            DateValidation dateEng2LeftValidation = new DateValidation(editJobEng2LeftText.Text);


            return output;
        }
    }
}
