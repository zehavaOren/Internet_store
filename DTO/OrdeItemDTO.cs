using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Entity;

namespace DTO
{
    public class OrderItemDTO
    {
        public int Productid { get; set; }
        public int Quentity { get; set; }

    }

}

