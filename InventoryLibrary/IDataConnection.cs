using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary
{
    public interface IDataConnection
    {
        ItemModel CreateItem(ItemModel model);
        BatteryModel CreateBattery(BatteryModel model);
        JobModel CreateJob(JobModel model);
        void UpdateJob(int id, JobModel model, float circul);
        void UpdateItem(int id, ItemModel model);
    }
}
