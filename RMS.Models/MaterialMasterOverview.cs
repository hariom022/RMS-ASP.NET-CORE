using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class MaterialMasterOverview
    {
        [Key]
        public int MaterialId { get; set; }
        public string? MaterialNumber { get; set; }
        public string? MaterialDescription { get; set; }
        public string? MaterialGroup { get; set; }
        public string? UnitOfMeasurement { get; set; }
        public string? MaterialType { get; set; }
    }
}
