using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Entity
{
    public partial class OrderItem
    {
        public int Id { get; set; }
        public int Orderid { get; set; }
        public int Productid { get; set; }
        public int Quentity { get; set; }
        [JsonIgnore]
        public virtual Order? Order { get; set; } = null!;
        [JsonIgnore]
        public virtual Product? Product { get; set; } = null!;
    }
}
