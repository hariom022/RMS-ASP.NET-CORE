using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class OrderSummary
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Product Code")]
        public string ProductCode { get; set; }
        [Display(Name = "Product Description ")]
        public string ProductDescription { get; set; }
        public int Quantity { get; set; }
        [Display(Name ="UOM")]
        public string UnitOfMeasurement {  get; set; }

    }
}
