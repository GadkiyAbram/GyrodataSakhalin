using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary
{
    public class ItemModel
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string Asset { get; set; }
        public string Arrived { get; set; }
        public string Invoice { get; set; }
        public string CCD { get; set; }
        public float Circulation { get; set; }  // should be named as in DB
        public string NameRussian { get; set; }
        public string PositionInCCD { get; set; }
        public string ItemStatus { get; set; }
        public string Box { get; set; }
        public string Container { get; set; }
        public string Comment { get; set; }
        // List of Jobs the Item took part in
        public List<List<JobModel>> itemJobs { get; set; } = new List<List<JobModel>>();


        public ItemModel() {  }

        public ItemModel(string item, string asset, string arrived, string invoice, string ccd, string nameRussian,
            string positionInCCD, string status, string box, string container, string comment)
        {
            Item = item;
            Asset = asset;
            Arrived = arrived;
            Invoice = invoice;
            CCD = ccd;
            NameRussian = nameRussian;
            PositionInCCD = positionInCCD;
            ItemStatus = status;
            Box = box;
            Container = container;
            Comment = comment;
        }
    }
}
