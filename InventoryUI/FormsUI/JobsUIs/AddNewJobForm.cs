using InventoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using InventoryUI.ApiHelpers;
using InventoryLibrary.Validation.JobValidation;
using InventoryUI.Validation.JobValidation;

namespace InventoryUI.FormsUI.JobsUIs
{
    public partial class AddNewJobForm : Form
    {
        string PathJobsAdd = "PathJobsAdd";
        string PathJobSelected = "PathJobSelected";
        public List<string> errorsAddJob = new List<string>();

        public AddNewJobForm()
        {
            InitializeComponent();
            WireUpComboBoxes();
            jobIssuesComboBox.SelectedIndex = 0;
        }

        private Uri UriConnectionForJobCreate()
        {
            UriBuilder uriBuilder = new UriBuilder();
            uriBuilder.Scheme = "http";
            uriBuilder.Host = Properties.Settings.Default.Host;
            uriBuilder.Port = Properties.Settings.Default.Port;
            uriBuilder.Path = System.Configuration.ConfigurationManager.AppSettings["PathDataForJobCreate"];

            return uriBuilder.Uri;
        }

        public void WireUpComboBoxes()
        {
            List<List<string>> data = null;
            Uri url = UriConnectionForJobCreate();

            var client = new WebClient();
            string token = System.Configuration.ConfigurationManager.AppSettings["Token"];
            client.Headers["Token"] = token;
            client.Headers.Add("Content-Type", "application/json");

            try
            {
                var content = client.DownloadString(url);

                if (content != null)
                {
                    var serializer = new DataContractJsonSerializer(typeof(List<List<string>>));
                    using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
                    {
                        data = (List<List<string>>)serializer.ReadObject(ms);

                        jobClientComboBox.DataSource = data[0];
                        jobGdpComboBox.DataSource = data[1];
                        jobModemComboBox.DataSource = data[2];
                        jobBullPlugComboBox.DataSource = data[3];
                        jobBatteryComboBox.DataSource = data[5];

                        //TODO- refactor 
                        List<string> engsOne = new List<string>(data[4]);
                        List<string> engsTwo = new List<string>(data[4]);

                        jobEngOneComboBox.DataSource = engsOne;
                        jobEngOneComboBox.SelectedIndex = 8;
                        jobEngTwoComboBox.DataSource = engsTwo;
                        jobEngTwoComboBox.SelectedIndex = 8;

                        //old version
                        //jobEngOneComboBox.DataSource = data[4];
                        //jobEngOneComboBox.SelectedIndex = 8;
                        //jobEngTwoComboBox.DataSource = data[4];
                        //jobEngTwoComboBox.SelectedIndex = 8;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
            //string jobMaxTemperature = jobMaxTemperatureText.Text;
            int result = 0;
            //var jobExists = ApiConnectorHelper.GetSelectedJobData<JobModel>(jobNumberText.Text, PathJobSelected).First();

            if (ValidateForm().Keys.First())
            {
                JobModel model = new JobModel(
                        jobNumberText.Text,
                        jobClientComboBox.Text,
                        jobGdpComboBox.Text,
                        jobModemComboBox.Text,
                        jobModemVersionText.Text,
                        jobBullPlugComboBox.Text,
                        CalculateFloatData(jobCirculationTime),
                        jobBatteryComboBox.Text,
                        jobMaxTemperatureText.Text,
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

                result = ApiConnectorHelper.SaveData<JobModel>(model, PathJobsAdd);
                if (result != 0)
                {
                    addJobButton.Text = $"Job { jobNumberText.Text } added";
                }
                else
                {
                    addJobButton.Text = "Smth went wrong";
                }
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
            jobFields.Add("jobJobNumber", jobNumberText.Text);
            jobFields.Add("jobCirculation", jobCirculationHoursText.Text);
            jobFields.Add("jobMaxTemperature", jobMaxTemperatureText.Text);
            jobFields.Add("engOneArrived", jobEng1ArrivedText.Text);
            jobFields.Add("engTwoArrived", jobEng2ArrivedText.Text);
            jobFields.Add("engOneLeft", jobEng1LeftText.Text);
            jobFields.Add("engTwoLeft", jobEng2LeftText.Text);
            jobFields.Add("jobContainer", jobContainerText.Text);
            jobFields.Add("containerArrived", jobContArrivedText.Text);
            jobFields.Add("containerLeft", jobContLeftText.Text);
            jobFields.Add("jobRig", jobRigText.Text);

            var output = JobValidation.ValidateJob(jobFields);

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

            WireUpComboBoxes();
        }
    }
}
