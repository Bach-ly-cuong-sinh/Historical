using System;
using System.Collections.Generic;

#nullable disable

namespace Historical.Models
{
    public partial class Feedback
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public int IsActive { get; set; }
        public int RelicId { get; set; }

        public virtual Relic Relic { get; set; }
    }
}
