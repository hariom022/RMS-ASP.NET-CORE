namespace ServiceContracts.DTO
{
    /// <summary>
    /// DTO class for adding consumption entry
    /// </summary>
    public class ConsumptionEntryAddRequest
    {
        public string? Plant { get; set; }
        public string Material { get; set; }
        public string MaterialDescription { get; set; }
        public string UOM { get; set; }
        public string ProductType { get; set; }
        public decimal QtyConsumed { get; set; }
        public DateTime DateOfConsumption { get; set; }
        public string MaterialDocument { get; set; }
        public decimal UnrestrictedStock { get; set; }
    }
}
