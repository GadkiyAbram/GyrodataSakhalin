using InventoryLibrary;
using InventoryUI.Validation.JobValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InventoryUI.FormsUI.JobsUIs
{
    public partial class EditJobForm : Form
    {
        string pathJobsEdit = "PathJobsEdit";
        string pathJobSelected = "PathJobSelected";
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
            if (jobList.Count() != 0)
            {
                foreach (var job in jobList)
                {
                    selectJobComboBox.Items.Add(job.JobNumber);
                }
                selectJobComboBox.SelectedIndex = 0;
            }
        }

        private void selectJobComboBox_SelectedIndexChanged(object sender, EventArgs exception)
        {
            LoadFormWithJobFromComboBox(selectJobComboBox.Text);
        }

        private void LoadFormWithJobFromComboBox(string selectedJob)
        {
            try
            {
                JobModel jobModel = ApiHelpers.ApiConnectorHelper.GetSelectedJobData<JobModel>(selectedJob, pathJobSelected).First();
                job_id = jobModel.Id;

                oldJobCircultaionHours = jobModel.CirculationHours;

                editJobLabel.Text = jobModel.JobNumber;
                editJobNumberText.Text = jobModel.JobNumber;
                editJobClientText.Text = jobModel.ClientName;
                editJobGdpText.Text = jobModel.GDP;
                editJobModemText.Text = jobModel.Modem;
                editJobModemVersionText.Text = jobModel.ModemVersion;
                editJobBbpText.Text = jobModel.Bullplug;
                editJobCirculationHoursText.Text = jobModel.CirculationHours.ToString();
                editJobMaxTemperatureText.Text = jobModel.MaxTemp.ToString();
                editJobBatteryText.Text = jobModel.Battery;

                editJobEngOneText.Text = jobModel.EngineerOne;
                editJobEngTwoText.Text = jobModel.EngineerTwo;
                editJobEng1ArrivedText.Text = jobModel.eng_one_arrived;
                editJobEng2ArrivedText.Text = jobModel.eng_two_arrived;
                editJobEng1LeftText.Text = jobModel.eng_one_left;
                editJobEng2LeftText.Text = jobModel.eng_two_left;

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
            float jobCirculationTime = float.Parse(editJobCirculationHoursText.Text);
            int result = 0;
            if (ValidateForm().Keys.First())
            {
                JobModel model = new JobModel(
                    editJobNumberText.Text,
                    editJobClientText.Text,
                    editJobGdpText.Text,
                    editJobModemText.Text,
                    editJobModemVersionText.Text,
                    editJobBbpText.Text,
                    jobCirculationTime,
                    editJobBatteryText.Text,
                    editJobMaxTemperatureText.Text,                            // check length, float
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

                ApiHelpers.ApiConnectorHelper.EditData<JobModel>(job_id.ToString(), model, pathJobsEdit);

                //foreach (IDataConnection db in GlobalConfig.Connections)
                //{
                //    db.UpdateJob(job_id, model, oldJobCircultaionHours);
                //}
                //if (result != 0)
                //{
                //    MessageBox.Show($"Job { model.JobNumber } corrected");
                //}
            }
            else
            {
                ErrorForm errorForm = new ErrorForm(ValidateForm().Values.First());
                errorForm.Show();
            }
        }

        private Dictionary<bool, List<string>> ValidateForm()
        {
            Dictionary<string, string> jobFields = new Dictionary<string, string>();
            //jobFields.Add("jobJobNumber", editJobNumberText.Text);
            jobFields.Add("jobCirculation", editJobCirculationHoursText.Text);
            jobFields.Add("jobMaxTemperature", editJobMaxTemperatureText.Text);
            jobFields.Add("engOneArrived", editJobEng1ArrivedText.Text);
            jobFields.Add("engTwoArrived", editJobEng2ArrivedText.Text);
            jobFields.Add("engOneLeft", editJobEng1LeftText.Text);
            jobFields.Add("engTwoLeft", editJobEng2LeftText.Text);
            jobFields.Add("jobContainer", editJobContainerText.Text);
            jobFields.Add("containerArrived", editJobContArrivedText.Text);
            jobFields.Add("containerLeft", editJobContLeftText.Text);
            jobFields.Add("jobRig", editJobRigText.Text);

            var output = JobValidation.ValidateJob(jobFields);

            return output;
        }
    }
}
