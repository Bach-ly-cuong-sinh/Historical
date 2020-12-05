using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Historical.Models
{
    public class ContactInputModel : Feedback
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int IsActive { get; set; }
        public int RelicId { get; set; }
    }
}
