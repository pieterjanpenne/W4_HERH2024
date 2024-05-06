namespace Assignment.Domain.Models
{

    /// <summary>
    /// The category.
    /// </summary>
    public class Menu : EntityBase
    {
        public int MenuId { get; set; }

        public string? Number { get; set; }

        public string? Details { get; set; }

        public decimal Price { get; set; }
    }
}
