using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class Product
    {
        public Product()
        {
            Inventorties = new HashSet<Inventorty>();
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Inventorty> Inventorties { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
