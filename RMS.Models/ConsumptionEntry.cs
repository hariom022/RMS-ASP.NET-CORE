namespace RMS.Models
{
    /// <summary>
    /// Domain Model for ConsumptionEntry
    /// </summary>
    public class ConsumptionEntry
    {
        public Guid ConsumptionEntryId { get; set; }
        public required Plant Plant { get; set; }
        public required Product Material { get; set; }
        public string? MaterialDescription { get; set; }
        public string? UOM { get; set; }
        public string? ProductType { get; set; }
        public decimal QtyConsumed { get; set; }
        public DateTime DateOfConsumption { get; set; }
        public string? MaterialDocument { get; set; }
        public decimal UnrestrictedStock { get; set; }
    }
}
