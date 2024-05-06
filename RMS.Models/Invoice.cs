using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string   Item { get; set; }
        public string MaterialCode { get; set; }
        public int Quantity { get; set; }

        public string MaterialDescription { get; set; }
        public double Rate { get; set; }
        public double Total {  get; set; }

    }
}
