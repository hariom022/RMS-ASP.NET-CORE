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

        public string MaterialCode { get; set; }
        public string Material { get; set; }

        public int Quantity { get; set; }
        public double Price { get; set; }

        public double Total {  get; set; }
    }
}
