using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class ProductMasterOverview
    {
        [Key]
        public int ProductId { get; set; }
        public string? ProductNumber { get; set; }
        public string? ProductDescription { get; set; }
        public string? ProductGroup { get; set; }
        public string? UnitOfMeasurement { get; set; }
        public string? ProductType { get; set; }
    }
}
