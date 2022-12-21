using System;
using System.Collections.Generic;

namespace Entity
{
    public partial class OrderItem
    {
        public int Id { get; set; }
        public int Orderid { get; set; }
        public int Productid { get; set; }
        public int Quentity { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
