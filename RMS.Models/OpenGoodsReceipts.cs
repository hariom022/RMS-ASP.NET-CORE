using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class OpenGoodsReceipts
    {
        [Key]
        public int ReceiptId { get; set; }
        public string Supplier {  get; set; }
        public DateTime Date {  get; set; }
        [Column("Material Name", TypeName ="varchar(40)")]
        public string MaterialName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
    }
}
