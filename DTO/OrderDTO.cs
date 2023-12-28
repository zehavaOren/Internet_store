using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Entity;

namespace DTO
{
    public class OrderDTO
    {
        
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public virtual IEnumerable<OrderItemDTO> OrderItems { get; set; }

    }

}

