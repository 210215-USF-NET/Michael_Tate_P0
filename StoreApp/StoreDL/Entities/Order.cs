using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class Order
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public int? Location { get; set; }
        public int? Customer { get; set; }

        public virtual Customer CustomerNavigation { get; set; }
        public virtual StoreLocation LocationNavigation { get; set; }
    }
}
