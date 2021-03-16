using System;

namespace CodeFirstEntity
{
    public class Person
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Telefono { get; set; }
        public string Stato { get; set; }
        public enum status
        {
            attivo,
            non_attivo,
            cancellato
        };
        public DateTime? LastLogin { get; set; }
    }
}
