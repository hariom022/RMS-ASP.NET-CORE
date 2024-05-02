using System.ComponentModel.DataAnnotations;

namespace RMS.Models
{
    public class Inquiry
    {
        [Key]
        public int No {  get; set; }
        public int RequestNo { get; set; }
        public string Customer { get; set; }
        public string RefNo { get; set; }
        public DateOnly RefDate { get; set; }
        public string MaterialNumber { get; set; }
        public string MaterialDescription { get; set; }
        public int Quantity { get; set; }
        public string UnitOfMeasurement { get; set; }
        public decimal Budget { get; set; }
        public string Branch { get; set; }
        public DateOnly ExpectedDelivery { get; set; }
    }
}
