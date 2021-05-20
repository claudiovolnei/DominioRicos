using System.Collections.Generic;
using System.Linq;
using PaymentContext.Domain.ValuesObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {        
        private IList<Subscription> _subscriptions;
        public Student(Name name,Document document, Email email)
        {
            this.Name = name;
            this.Document = document;
            this.Email = email;  

            _subscriptions = new List<Subscription>();        

            AddNotifications(name, document, email);            
        }
        public Name Name { get; private set;}
        public string LastName { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }
        public void AddSubscription(Subscription subscription)
        {            
            //Cancela todas as outras assinaturas, e coloca esta com principal
            foreach (var sub in Subscriptions)            
                sub.Inactivate();            

            _subscriptions.Add(subscription);
        }
    }
}