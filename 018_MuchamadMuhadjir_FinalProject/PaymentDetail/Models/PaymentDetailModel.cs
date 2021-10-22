using System;
namespace PaymentDetail.Models
{
    public class PaymentDetailModel
    {
        public int Id {get; set;}
        public string cardOwnerName {get; set;}
        public string cardNumber {get; set;}
        public DateTime expirationDate {get;set;}
        public string securityCode{get; set;}
        
    }
}