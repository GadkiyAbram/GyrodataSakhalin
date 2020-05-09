using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary
{
    public class JobModel
    {
        public int Id { get; set; }
        public string JobNumber { get; set; }
        public string ClientName { get; set; }
        public string GDP { get; set; }
        public string Modem { get; set; }
        public string ModemVersion { get; set; }
        public string Bullplug { get; set; }
        public float CirculationHours { get; set; }
        public string Battery { get; set; }
        public string MaxTemp { get; set; }
        public string EngineerOne { get; set; }
        public string EngineerTwo { get; set; }
        public string eng_one_arrived { get; set; }
        public string eng_two_arrived { get; set; }
        public string eng_one_left { get; set; }
        public string eng_two_left { get; set; }
        public string Container { get; set; }
        public string ContainerArrived { get; set; }
        public string ContainerLeft { get; set; }
        public string Rig { get; set; }
        public string Issues { get; set; }
        public string Comment { get; set; }

        public JobModel() { }

        public JobModel(string jobNumber, string client, string gdp, string modem, string modemVersion, string bullplug,
                        float circulationHours, string battery, string maxTemp, string engineerOne, string engineerTwo,
                        string engineerOneArrived, string engineerTwoArrived, string engineerOneLeft, string engineerTwoLeft,
                        string container, string containerArrived, string containerLeft, string rig, string issues, string comment)
        {
            this.JobNumber = jobNumber;
            this.ClientName = client;
            this.GDP = gdp;
            this.Modem = modem;
            this.ModemVersion = modemVersion;
            this.Bullplug = bullplug;
            this.CirculationHours = circulationHours;
            this.Battery = battery;
            this.MaxTemp = maxTemp;
            this.EngineerOne = engineerOne;
            this.EngineerTwo = engineerTwo;
            this.eng_one_arrived = engineerOneArrived;
            this.eng_two_arrived = engineerTwoArrived;
            this.eng_one_left = engineerOneLeft;
            this.eng_two_left = engineerTwoLeft;
            this.Container = container;
            this.ContainerArrived = containerArrived;
            this.ContainerLeft = containerLeft;
            this.Rig = rig;
            this.Issues = issues;
            this.Comment = comment;
        }
    }
}
