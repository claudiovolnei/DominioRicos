using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValuesObjects
{
    public class Name : ValueObjects
    {
        public Name(string firstName, string lastName)
        {
            this.FirstNmae = firstName;
            this.LastName = lastName;

        }
        public string FirstNmae { get; private set; }
        public string LastName { get; private set; }
    }

}