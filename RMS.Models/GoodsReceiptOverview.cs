using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class GoodsReceiptOverview
    {
        [Key]
        public int RequestNo { get; set; }
        [Column ("Quotation No", TypeName = "varchar(50)")]
        public string QuotationNo { get; set; }
        [Column("Sales No", TypeName ="varchar(20)")]
        public string SalesNo { get; set; }
        [Column ("OBD No", TypeName ="varchar(20)")]
        public string OBDNo { get; set; }
        public string GoodReceipt {  get; set; }
    }
}
