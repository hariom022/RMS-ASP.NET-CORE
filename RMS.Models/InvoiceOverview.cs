using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class InvoiceOverview
    {
        public string Item { get; set; }
        public string MaterialCode { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public double Rate { get; set; }
        public double Total { get; set; }
    }

    public class InvoiceModelOverview
    {
        public double SubTotal { get; set; }
        public double Tax {  get; set; }
        public double TotalAmount { get; set; }

        public List<InvoiceOverview> Invoice { get; set; }

    }
}