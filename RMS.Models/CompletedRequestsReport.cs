using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class CompletedRequestsReport
    {
        [Key]
        public int RequestId { get; set; }
        [Column("Product Name", TypeName ="varchar(50)")]
        public string ProductName { get; set; }
        public int Quantity { get; set; }

        public string CompletedBy { get; set; }
        public DateOnly DateCompleted {  get; set; }
    }
}
