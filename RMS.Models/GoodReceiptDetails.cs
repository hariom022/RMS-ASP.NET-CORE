using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public  class GoodReceiptDetails
    {
        public string MaterialCode { get; set; }
        public string MaterialType { get; set; }
        public int Quantity { get; set; }
        public string UOM { get; set; }
        public decimal Rate { get; set; }
        public decimal Total { get; set; }
    }
            
    public class GoodReceiptDetailViewModel
    {
        public string RequestNo { get; set; }
        public string QuotationNo { get; set; }
        public string SalesNo { get; set; }
        public string OBDNo { get; set; }
        public DateTime GRDate { get; set; }
        public int TotalSKUQuantity { get; set; }
        public int TotalReceivedQuantity { get; set; }
        public decimal TotalReceiptAmount { get; set; }
        public List<GoodReceiptDetails> goodReceiptDetails { get; set; }
    }
}
