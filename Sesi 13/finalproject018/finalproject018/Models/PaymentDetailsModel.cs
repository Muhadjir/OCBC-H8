using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalproject018.Models
{
    public class PaymentDetailsModel
    {
        public int paymentDetailId { get; set; }
        public string cardOwnerName { get; set; }
        public string cardNumber { get; set; }
        public string expirationDate { get; set; }
        public string securityCode { get; set; }
    }
}
