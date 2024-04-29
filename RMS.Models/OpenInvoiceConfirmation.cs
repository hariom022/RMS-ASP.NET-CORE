using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class OpenInvoiceConfirmation
    {
        [Key]
        public int Id { get; set; }
        [Column ("Invoice Id", TypeName ="varchar(30)")]
        public string InvoiceId { get; set; }
        public string Customer {  get; set; }
        public DateOnly Date {  get; set; }
        public double TotalAmount { get; set; }
        public string Status { get; set; }
    }
}
