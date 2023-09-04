using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct1
{
    public class Box
    {
        public double BaseSize { get; }
        public double Height { get; }
        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int AgingDuration { get; set; } // will be useful adjusting the expiration date in the settings(how many days to expire upon adding the box)

        public Box(double baseSize, double height, int quantity, int agingDuration)
        {
            BaseSize = baseSize;
            Height = height;
            Quantity = quantity;
            AgingDuration = agingDuration;
            ExpiryDate = DateTime.Now.AddDays(agingDuration);
        }
        public override string ToString() //will be shown in the list of available boxes and expired boxes
        {
            return $"Base Size: {BaseSize}, Height: {Height}, Quantity: {Quantity}, Expiry Date: {ExpiryDate}";
        }
    }
}
