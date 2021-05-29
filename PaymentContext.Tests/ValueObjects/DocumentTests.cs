using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValuesObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class DocumentTests
    {
        //Red, Green, Rafctore
        [TestMethod]
        public void SholdReturnErrorWhenCNPJisInvalid()
        {
            var doc = new Document("123", EDocumentType.CNPJ);
            Assert.IsFalse(doc.IsValid);
        }

        [TestMethod]
        public void SholdReturnSuccessWhenCNPJisInvalid()
        {
            var doc = new Document("12345678990123", EDocumentType.CNPJ);
            Assert.IsTrue(doc.IsValid);
        }
        [TestMethod]
        public void SholdReturnErrorWhenCPFisInvalid()
        {
            var doc = new Document("1234", EDocumentType.CPF);
            Assert.IsFalse(doc.IsValid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("11111111111")]
        [DataRow("22222222222")]
        public void SholdReturnSuccessWhenCPFisInvalid(string cpf)
        {
            var doc = new Document(cpf, EDocumentType.CPF);
            Assert.IsTrue(doc.IsValid);
        }
    }
}
