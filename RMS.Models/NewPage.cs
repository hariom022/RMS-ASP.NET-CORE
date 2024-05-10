using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public  class NewPage
    {
        [Key]
        public int Id { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
    }
}
