using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Models
{
    public class PaggingFilter
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }
}
