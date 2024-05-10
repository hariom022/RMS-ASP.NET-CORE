using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class OutboundDeliveryNo
    {
        [Key]
        public int ID { get; set; }
        public string OBDNo { get; set; }
        public string ProductNo { get; set; }
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Display(Name = "Picked Quantity")]
        public int PickedQuantity { get; set; }
        public string Branch {  get; set; }
        [Display(Name = "Delevered Date")]
        public DateOnly DeleveredDate { get; set; }
    }
}
