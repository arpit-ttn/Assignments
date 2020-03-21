using System;
using System.Collections.Generic;

namespace Entity_DBFirst.Models
{
    public partial class Products
    {
        public Products()
        {
            Orders = new HashSet<Orders>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? Mrp { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
