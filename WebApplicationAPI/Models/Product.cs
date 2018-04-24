using System;
using System.Collections.Generic;

namespace WebApplicationAPI.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public string Package { get; set; }
        public bool IsDiscontinued { get; set; }
        public ICollection<OrderItem> OrderItem { get; set; }
        
    }
}
