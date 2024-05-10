using System.ComponentModel.DataAnnotations;

namespace RMS.Models
{

    public class ConsumptionEntry
    {
        [Key]
        public int ConsumptionEntryId { get; set; }
        public string  Plants { get; set; }
        public string  Product { get; set; } 
        public string? ProductDescription { get; set; }
        public string? UnitOfMeasurement { get; set; }
        public string? ProductType { get; set; }
        public decimal QtyConsumed { get; set; }
        public DateOnly DateOfConsumption { get; set; }
        public string? ProductDocument { get; set; }
        public decimal UnrestrictedStock { get; set; }
    }
   
}
