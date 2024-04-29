using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class LastConsumptionReport
    {
        [Key]
        public int Id { get; set; }
        [Column("Medicine Name",TypeName ="varchar(50)")]
        public string MedicineName { get; set; }
        [Column("Quantity Consumed",TypeName ="int")]
        public int QuantityConsumed { get; set; }
        public DateOnly DateConsumed { get; set; }
        public string Department {  get; set; }
    }
}
