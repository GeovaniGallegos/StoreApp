using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public decimal SellPrice { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }

    }
}
