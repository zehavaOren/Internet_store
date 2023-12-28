using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Entity
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public virtual ICollection<Product> Products { get; set; }
    }
}
