using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class SalesOrderDetails
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        [Column("Product Name", TypeName ="varchar(50)")]
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
        [Column("Customer Name", TypeName = "varchar(50)")]
        public string CustomerName { get; set; }
        public DateOnly Date {  get; set; }

    }
}
