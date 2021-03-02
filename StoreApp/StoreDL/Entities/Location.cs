using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class Location
    {
        public Location()
        {
            Orders = new HashSet<Order>();
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        public string Name { get; set;}
        public string City { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public int Zip { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public static implicit operator string(Location v)
        {
            throw new NotImplementedException();
        }
    }
}
