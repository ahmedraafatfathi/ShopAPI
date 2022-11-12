using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Models
{
    public class ProductDto
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public float Price { get; set; }
        public int AvailableQty { get; set; }
        public Guid CategoryId { get; set; }
    }
}
