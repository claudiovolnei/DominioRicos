using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValuesObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            this.Number = number;           
            this.Type = type;     

            AddNotifications(new Contract<Document>()
                .Requires()
                .IsTrue(Validate(), "Document.Number", "Documento inválido")
            );      
        }
        public string Number { get; private set; }    
        public EDocumentType Type { get; set; }  

        private bool Validate() 
        {
            if(Type == EDocumentType.CNPJ && Number.Length == 14)
                return true;

            if(Type == EDocumentType.CPF && Number.Length == 11)
                return true;

            return false;
        }  
    }

}