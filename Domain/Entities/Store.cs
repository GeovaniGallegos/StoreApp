using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Store
    {
        [Key]
        public  Guid Id{ get; set; }
        public string? Name{ get; set; }
        public string? Address { get; set; }
        public string? Type { get; set; }
        public string? Phone { get; set; }
        public ICollection<Stock>?  Stocks { get; set; }

    }
}
