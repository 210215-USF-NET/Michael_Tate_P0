using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class StoreLocation
    {
        public StoreLocation()
        {
            Inventorties = new HashSet<Inventorty>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public int Zip { get; set; }

        public virtual ICollection<Inventorty> Inventorties { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
