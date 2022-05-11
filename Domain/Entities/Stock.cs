﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Stock
    {   
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int MinQuantity { get; set; }
        
        Product? Product { get; set; }
    }
}
