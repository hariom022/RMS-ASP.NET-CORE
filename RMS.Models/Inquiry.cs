namespace RMS.Models
{
    public class Inquiry
    {
        public int RequestNo { get; set; }
        public string Customer { get; set; }
        public string RefNo { get; set; }
        public DateTime RefDate { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int Quantity { get; set; }
        public string UOM { get; set; }
        public decimal Budget { get; set; }
        public string Branch { get; set; }
        public DateTime ExpectedDelivery { get; set; }
    }
}
