using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class Inventorty
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public int? Product { get; set; }
        public int? Location { get; set; }

        public virtual StoreLocation LocationNavigation { get; set; }
        public virtual Product ProductNavigation { get; set; }
    }
}
