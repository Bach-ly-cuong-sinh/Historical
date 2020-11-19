using System;
using System.Collections.Generic;

#nullable disable

namespace Historical.Models
{
    public partial class Category
    {
        public Category()
        {
            Relics = new HashSet<Relic>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int IsActive { get; set; }

        public virtual ICollection<Relic> Relics { get; set; }
    }
}
