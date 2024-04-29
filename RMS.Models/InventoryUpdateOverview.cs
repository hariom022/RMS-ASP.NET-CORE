using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class InventoryUpdateOverview
    {
        [Key]
        public string ProductCode { get; set; }
        [Column("Product Code", TypeName = "varchar(50)")]
        public string Description { get; set; }

        public string Uom { get; set; }
        public int OpenStock { get; set; }
        public int Consumption { get; set; }
        public string Plant { get; set; }
    }
}
