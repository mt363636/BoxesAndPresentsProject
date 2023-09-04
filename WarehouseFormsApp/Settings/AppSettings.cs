using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseFormsApp.Settings;
using WarehouseFormsApp;

namespace WarehouseFormsApp.Settings
{
    public class AppSettings  // proerties showing the available settings in the program
    {
        public int MaxQuantity { get; set; }
        public int SuitableQuantity { get; set; }
        public int AgingDuration { get; set; }
        public double MaxDistancePercentage { get; set; }
    }

}
