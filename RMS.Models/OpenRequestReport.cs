using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class OpenRequestReport
    {
        [Key]
        public int Id { get; set; }
        [Column("Product Name", TypeName ="varchar(30)")]
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TotalValue { get; set; }
    }
}
