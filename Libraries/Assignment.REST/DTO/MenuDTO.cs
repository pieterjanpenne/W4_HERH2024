using Assignment.Repository.Models;
using System.ComponentModel.DataAnnotations;

namespace Assignment.REST.DTO
{
    public class MenuDTO
    {
        public int MenuId { get; set; }

        public string? Number { get; set; }

        public string? Details { get; set; }

        public decimal Price { get; set; }
    }
}
