using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct1
{
    public class PurchaseBoxResult  //we will handle attemts of buying or failing to buy a gift for a suitable box
    {
        public bool IsSuccess { get; }
        public string ErrorMessage { get; }
        public Box PurchasedBox { get; set; }

        public PurchaseBoxResult(bool isSuccess, string errorMessage, Box purchasedBox)
        {
            IsSuccess = isSuccess;
            ErrorMessage = errorMessage;
            PurchasedBox = purchasedBox;
        }
        public PurchaseBoxResult(bool isSuccess, string errorMessage)
        {
            IsSuccess = isSuccess;
            ErrorMessage = errorMessage;
        }

    }
}
