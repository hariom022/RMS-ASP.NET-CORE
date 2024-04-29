using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class InventoryStatusReport
    {
        [Key]
        public int Id { get; set; }
        [Column("Item Name", TypeName ="varchar(50)")]
        public string ItemName { get; set; }
        public int QuantityAvailable { get; set; }
        public int MinimumQuantity { get; set; }
        public string Status { get; set; }
    }
}
