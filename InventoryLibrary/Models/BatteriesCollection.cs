using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary.Models
{
    public class BatteriesCollection
    {
        private List<BatteryModel> batteries;

        public List<BatteryModel> Batteries { get => batteries; set => batteries = value; }
    }
}
