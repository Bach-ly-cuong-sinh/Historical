using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Historical.Models
{
    public class FeedBackOutputModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public int IsActive { get; set; }
        public int RelicId { get; set; }
        public string RelicName { get; set; }
        public string CreateDateStr
        {
            get
            {
                return CreatedDate.ToString("dd/MM/yyyy HH:mm");
            }
            set { }
        }
    }
}
