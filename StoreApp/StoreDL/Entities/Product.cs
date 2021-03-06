﻿using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public int ProductName { get; set; }
        public int PieCount { get; set; }
        public decimal Price { get; set; }
        public int Location { get; set; }

        public virtual Location LocationNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
