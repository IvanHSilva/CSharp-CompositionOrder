using System;

namespace CompositionOrder.Entities {
    public class Client {
        // Attributes
        public string Name { get; set; }
        public string EMail { get; set; }
        public DateTime BirthDate { get; set; }

        // Constructors
        public Client() { }

        public Client(string name, string eMail, DateTime birthDate) {
            Name = name;
            EMail = eMail;
            BirthDate = birthDate;
        }
    }
}
