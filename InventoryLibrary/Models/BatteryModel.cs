using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary
{
    public class BatteryModel
    {
        public int Id { get; set; }
        public string BoxNumber { get; set; }
        public string BatteryCondition { get; set; }
        public string SerialOne { get; set; }
        public string SerialTwo { get; set; }
        public string SerialThree { get; set; }
        public string CCD { get; set; }
        public string Invoice { get; set; }
        public string Status { get; set; }
        public string Arrived { get; set; }
        public string Container { get; set; }
        public string Comment { get; set; }

        public BatteryModel() { }

        public BatteryModel(string boxNumber, string batteryCondition, string serialOne, string serialTwo,
                            string serialThree, string ccd, string invoice, string status, string arrived,
                            string container, string comment)
        {
            this.BoxNumber = boxNumber;
            this.BatteryCondition = batteryCondition;
            this.SerialOne = serialOne;
            this.SerialTwo = serialTwo;
            this.SerialThree = serialThree;
            this.CCD = ccd;
            this.Invoice = invoice;
            this.Status = status;
            this.Arrived = arrived;
            this.Container = container;
            this.Comment = comment;
        }
    }
}
