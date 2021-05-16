using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValuesObjects
{
    public class Email : ValueObjects
    {
        public Email(string address)
        {
            this.Address = address;
        }
        public string Address { get; private set; }
    }

}