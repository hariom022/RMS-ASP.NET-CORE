using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        [Display(Name = "Invoice No")]
        public string   InvoiceNo { get; set; }
        [Display(Name ="Customer Name")]
        public string CustomerName { get; set; }
        [Display(Name ="Customer No")]
        public string CustomerNo{ get; set; }
        [Display(Name ="Product No")]
        public string ProductNo { get; set; }
        [Display(Name ="Product Name")]
        public string ProductName { get; set; }
        [Display(Name ="Invoiced Qty")]
        public int InvoicedQty { get; set; }
        [Display(Name ="Net Value")]
        public double NetValue { get; set; }

    }
}
