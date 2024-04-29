using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class QuotationDetails
    {
        
        public string MaterialCode { get; set; }
        public string MaterialType { get; set; }
        public string Uom {  get; set; }
        public int Quantity { get; set; }
        public double Rate { get; set; }
        public double Total { get; set; }
    }
    public class QuotationDetailsViewModel
    {
        public int RequestNo { get; set; }
        public string QuotationId { get; set; }
        public DateTime Date { get; set; }

        public List<QuotationDetails> QuotationsData { get; set; }
    }
}
