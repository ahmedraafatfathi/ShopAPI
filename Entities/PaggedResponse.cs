using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class PagedResponse<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }
        public T Data { get; set; }

    }
}
