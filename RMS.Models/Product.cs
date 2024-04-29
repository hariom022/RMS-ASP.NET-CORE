using System.ComponentModel.DataAnnotations;

namespace RMS.Models
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
        public string? ProductNumber { get; set; }
        public string? ProductDescription { get; set; }
        public string? ProductGroup { get; set; }
        public string? UnitOfMeasurement { get; set; }
        public string? ProductType { get; set; }
    }
}
