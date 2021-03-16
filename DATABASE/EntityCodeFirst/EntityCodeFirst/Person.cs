using System;

namespace EntityCodeFirst
{
    public class Person
    {
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
    }
}
