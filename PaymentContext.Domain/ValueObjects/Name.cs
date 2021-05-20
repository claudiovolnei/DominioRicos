using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValuesObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;

            if(string.IsNullOrEmpty(FirstName))
                AddNotification("FirtName","Nome inválido.");

        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }

}