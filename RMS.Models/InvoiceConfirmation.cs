using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class InvoiceConfirmation
    {
        public string MaterialCode { get; set; }
        public string Material { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Total {  get; set; }
    }

    public class InvoiceModelViewConfirmation
    {
        public double TotalAmount { get; set; }
        public int InvoiceNo { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }   
        public string Email { get; set; }

        public List<InvoiceConfirmation> InvoiceConf {  get; set; }

    }
}
