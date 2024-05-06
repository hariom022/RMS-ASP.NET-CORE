using System.ComponentModel.DataAnnotations;

namespace RMS.Models
{

    public class ConsumptionEntry
    {
        [Key]
        public int ConsumptionEntryId { get; set; }
        public string  Plants { get; set; }
        public string  Material { get; set; } 
        public string? MaterialDescription { get; set; }
        public string? UnitOfMeasurement { get; set; }
        public string? MaterialType { get; set; }
        public decimal QtyConsumed { get; set; }
        public DateOnly DateOfConsumption { get; set; }
        public string? MaterialDocument { get; set; }
        public decimal UnrestrictedStock { get; set; }
    }
   
}
