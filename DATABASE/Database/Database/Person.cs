using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Person
    {
        // Variable
        public int id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string telefono { get; set; }
        public string stato { get; set; }
        public enum status
        {
            attivo,
            non_attivo,
            cancellato
        };
        public DateTime? lastLogin { get; set; }

        // Empty Default construttor
        public Person()
        {
        }

        // Default construttor with parameter
        public Person(int _id, string _firstName, string _lastName, string _email, string _password, string _telefono, string _status, DateTime _lastLogin)
        {
            // Class initialization
            id = _id;
            lastName = _lastName;
            firstName = _firstName;
            email = _email;
            password = _password;
            telefono = _telefono;
            stato = _status;
            lastLogin = _lastLogin;
        }
    }
}
