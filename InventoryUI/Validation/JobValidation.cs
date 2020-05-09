using InventoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryUI.Validation.JobValidation
{
    public class JobValidation
    {
        static string PathJobSelected = "PathJobSelected";

        public static Dictionary<bool, List<string>> ValidateJob(Dictionary<string, string> jobFields)
        {
            Dictionary<bool, List<string>> result = new Dictionary<bool, List<string>>();
            bool output = true;
            List<string> errorsJob = new List<string>();

            // Job Number validation
            //if (jobFields["jobJobNumber"].Length != 0)
            if (jobFields.ContainsKey("jobJobNumber"))
            {
                string jobJobNumber = jobFields["jobJobNumber"];
                string jobNumberPattern = @"^([A-Z]{2})([0-9]{4})([A-Z]{3})([0-9]{3})$";
                JobModel job = ApiHelpers.ApiConnectorHelper.GetSelectedJobData<JobModel>(jobJobNumber, PathJobSelected).FirstOrDefault();
                if (job != null)
                {
                    output = false;
                    errorsJob.Add($"Job {jobJobNumber} already exists");
                }
                if (jobJobNumber.Length == 0)
                {
                    output = false;
                    errorsJob.Add("Job Number couldn't be empty");
                }
                if (jobJobNumber.Length > 12)
                {
                    output = false;
                    errorsJob.Add("Job Number should be less 12 signs");
                }
                if (!UnitValidationRegex.Validate(jobJobNumber, jobNumberPattern))
                {
                    output = false;
                    errorsJob.Add("Wrong Job Number pattern");
                }
            }

            // Circulation validation
            string jobCirculation = jobFields["jobCirculation"];
            float circulation = 0;
            bool ValidateCirculation = float.TryParse(jobCirculation, out circulation);
            if (!ValidateCirculation)
            {
                output = false;
                errorsJob.Add("Wrong Circulation value");
            }

            // MaxTemperature validating
            string jobMaxTemperature = jobFields["jobMaxTemperature"];
            float maxTemperature = 0;
            bool ValidateMaxTemperature = float.TryParse(jobMaxTemperature, out maxTemperature);
            if (!ValidateMaxTemperature)
            {
                output = false;
                errorsJob.Add("Wrong Max Temperature value");
            }

            // Arrived Date validation
            string engOneArrived = null;
            string engTwoArrived = null;
            string engOneLeft = null;
            string engTwoLeft = null;
            string datePattern = @"^([0-9]{4})-([0-9]{2}-([0-9]{2}))$";

            // Engineer One Arriving
            if (jobFields["engOneArrived"].Length != 0)
            {
                engOneArrived = jobFields["engOneArrived"];
                
                if (engOneArrived.Length > 10)
                {
                    output = false;
                    errorsJob.Add("Arriving date Eng 1 Length should be <= 10");
                }
                if (!UnitValidationRegex.Validate(engOneArrived, datePattern))
                {
                    output = false;
                    errorsJob.Add("Wrong Arriving date Eng 1 pattern");
                }
            }

            // Engineer Two Arriving
            if (jobFields["engTwoArrived"].Length != 0)
            {
                engTwoArrived = jobFields["engTwoArrived"];

                if (engTwoArrived.Length > 10)
                {
                    output = false;
                    errorsJob.Add("Arriving date Eng 2 Length should be <= 10");
                }
                if (!UnitValidationRegex.Validate(engTwoArrived, datePattern))
                {
                    output = false;
                    errorsJob.Add("Wrong Arriving date Eng 2 pattern");
                }
            }

            // Engineer One Leaving
            if (jobFields["engOneLeft"].Length != 0)
            {
                engOneLeft = jobFields["engOneLeft"];

                if (engOneLeft.Length > 10)
                {
                    output = false;
                    errorsJob.Add("Leaving date Eng 1 Length should be <= 10");
                }
                if (!UnitValidationRegex.Validate(engOneLeft, datePattern))
                {
                    output = false;
                    errorsJob.Add("Wrong Leaving date Eng 1 pattern");
                }
            }

            // Engineer Two Leaving
            if (jobFields["engTwoLeft"].Length != 0)
            {
                engTwoLeft = jobFields["engTwoLeft"];

                if (engTwoLeft.Length > 10)
                {
                    output = false;
                    errorsJob.Add("Leaving date Eng 2 Length should be <= 10");
                }
                if (!UnitValidationRegex.Validate(engTwoLeft, datePattern))
                {
                    output = false;
                    errorsJob.Add("Wrong Leaving date Eng 2 pattern");
                }
            }

            // TODO - Add validation, comparing arrived and left time, left time should be later

            // Container validation
            string jobContainer = jobFields["jobContainer"];
            if (jobContainer.Length > 20)
            {
                errorsJob.Add("Container Length should be <= 20");
            }

            // Container Arriving
            if (jobFields["containerArrived"].Length != 0)
            {
                string containerArrived = jobFields["containerArrived"];

                if (containerArrived.Length > 10)
                {
                    output = false;
                    errorsJob.Add("Arriving date Container Length should be <= 10");
                }
                if (!UnitValidationRegex.Validate(containerArrived, datePattern))
                {
                    output = false;
                    errorsJob.Add("Wrong Arriving date Container pattern");
                }
            }

            // Container Leaving
            if (jobFields["containerLeft"].Length != 0)
            {
                string containerLeft = jobFields["containerLeft"];

                if (containerLeft.Length > 10)
                {
                    output = false;
                    errorsJob.Add("Leaving date Container Length should be <= 10");
                }
                if (!UnitValidationRegex.Validate(containerLeft, datePattern))
                {
                    output = false;
                    errorsJob.Add("Wrong Leaving date Container pattern");
                }
            }

            // Rig validation
            string jobRig = jobFields["jobRig"];
            if (jobRig.Length > 20)
            {
                errorsJob.Add("Rig Length should be <= 20");
            }

            result.Add(output, errorsJob);

            return result;
        }
    }
}
