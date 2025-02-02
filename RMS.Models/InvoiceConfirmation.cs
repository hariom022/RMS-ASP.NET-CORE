﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class InvoiceConfirmation
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Product Code")]
        public string ProductCode { get; set; }
        public string Product { get; set; }

        public int Quantity { get; set; }
        public double Price { get; set; }

        public double Total {  get; set; }
    }
}
