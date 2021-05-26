using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValuesObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            this.Address = address;
            
            AddNotifications(new Contract<Email>()
                .Requires()
                .IsEmail(Address, "Email.Address", "E-mail inválido.")
            );
        }
        public string Address { get; private set; }
    }

}