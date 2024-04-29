using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class QuotationApproval
    {
        [Key]
        public int Id { get; set; }
        [Column("Request No", TypeName ="int")]
        public int RequestNo { get; set; }
        [Column("Quotation No" , TypeName ="varchar(20)" )]
        public string? Quotation { get; set; }
        public double TotalAmount { get; set; }
      
    }
}
