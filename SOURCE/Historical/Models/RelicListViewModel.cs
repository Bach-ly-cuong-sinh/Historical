using Historical.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Historical.Models
{
    public class RelicListViewModel
    {
        public IEnumerable<Relic> Relics { get; set; }
        public PageInfo Pageinfo { get; set; }
        public int CurrentCategory { get; set; }
    }
}
