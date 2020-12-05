using System;
using System.Collections.Generic;

#nullable disable

namespace Historical.Model
{
    public partial class Relic
    {
        public Relic()
        {
            Feedbacks = new HashSet<Feedback>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string MapLinks { get; set; }
        public int IsActive { get; set; }
        public DateTime? CraetedDate { get; set; }
        public int CateId { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }

        public virtual Category Cate { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
