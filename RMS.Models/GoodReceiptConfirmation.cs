using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class GoodReceiptConfirmation
    {
        [Key]
        public int Id { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialType { get; set; }
        public int Quantity { get; set; }
        public string UOM { get; set; }
        public decimal Rate { get; set; }
        public decimal Total { get; set; }
    }

    
}
