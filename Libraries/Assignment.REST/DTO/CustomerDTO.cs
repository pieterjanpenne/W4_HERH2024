using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.REST.DTO
{
    public class CustomerDTO
    {
        public int CustomerId { get; set; }
        public string? Username { get; set; }
        public string? Pwd { get; set; }    
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? TcIdentityNum { get; set; }
        public string? PhoneNumber { get; set; }
        public string? MailAddress { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }

    }
}
