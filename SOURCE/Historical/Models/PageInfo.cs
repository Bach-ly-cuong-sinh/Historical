using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Historical.Models
{
    public class PageInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalItems / ItemsPage);
    }
}
