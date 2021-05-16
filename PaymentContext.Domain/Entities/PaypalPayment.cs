using System;
using PaymentContext.Domain.ValuesObjects;

namespace PaymentContext.Domain.Entities
{
    public class PaypalPayment : Payment
    {
        public PaypalPayment(
            string transactionCode,
            DateTime paidDate, 
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            string payer,
            Document document,
            Email email,
            Address address) : base(
                paidDate,
                expireDate,
                total,
                totalPaid,
                payer,
                document,
                email,
                address)
        {
            this.TransactionCode = transactionCode;

        }
        public string TransactionCode { get; set; }
    }
}