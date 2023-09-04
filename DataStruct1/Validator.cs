using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct1
{
    public class Validator  //we ensure here if all data is inserted correctly and not by negative numbers or a number not within percentage mark
    {
        public static bool IsPositiveQuantity(int quantity)
        {
            return quantity > 0;
        }

        public static bool AreNonNegative(double value)
        {
            return value >= 0;
        }

        public static bool IsValidSuitableQuantity(int suitableQuantity, int maxQuantity)
        {
            return suitableQuantity > 0 && suitableQuantity <= maxQuantity;
        }

        public static bool IsWithinPercentage(double value, double reference, double percentage)
        {
            double difference = Math.Abs(value - reference);
            double threshold = reference * (percentage / 100);
            return difference <= threshold;
        }
    }
}
