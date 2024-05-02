using System.ComponentModel.DataAnnotations;

namespace RMS.Models
{

    public class ConsumptionEntry
    {
        [Key]
        public int ConsumptionEntryId { get; set; }
        public required InventoryUpdateOverview Inventory { get; set; }
        public required MaterialMasterOverview MaterialMaster { get; set; } 
        public string? MaterialDescription { get; set; }
        public string? UOM { get; set; }
        public string? ProductType { get; set; }
        public decimal QtyConsumed { get; set; }
        public DateTime DateOfConsumption { get; set; }
        public string? MaterialDocument { get; set; }
        public decimal UnrestrictedStock { get; set; }
    }
   
}
