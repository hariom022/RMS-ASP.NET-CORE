using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class ProofOfDelivery
    {
        [Key]
        public int Id { get; set; }
        public int RequestNo { get; set; }
        public string QuotationNo { get; set; }
        public string SalesNo { get;set; }

        public string OBDNo { get; set; }
        public string GoodReceipt {  get; set; }
        public string PODNo { get; set; }
    }
}
