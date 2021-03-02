﻿using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public int? Location { get; set; }
        public int? Customer { get; set; }
        public int? Product { get; set; }

        public virtual Customer CustomerNavigation { get; set; }
        public virtual Location LocationNavigation { get; set; }
        public virtual Product ProductNavigation { get; set; }
    }
}
