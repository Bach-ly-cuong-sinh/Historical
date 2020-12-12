using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Historical.Models
{
    public class UserOutputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IsActive { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedDateStr
        {
            set { }
            get
            {
                return CreatedDate.ToString("dd/yy/MMMM HH:mm");
            }
        }
    }
}
