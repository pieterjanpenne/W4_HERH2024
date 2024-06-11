using System;

namespace Assignment.Domain.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string? Username { get; set; }

        public string Pwd { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public int? TcIdentityNum { get; set; }

        public string? PhoneNumber { get; set; }

        public string MailAddress { get; set; } = null!; // Adresveld toegevoegd

        public DateTime? BirthDate { get; set; }

        public string? Country { get; set; }

        public string? City { get; set; }
    }
}
