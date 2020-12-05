using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Historical.Models
{
    public class RelicsOutputModel
    {
        public int RelicsID { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string RelicsName { get; set; }
        public string Address { get; set; }
        public string MapUrl { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedDateStr
        {
            get 
            {
                return CreatedDate.ToString("dd/MM/yyyy HH:mm"); 
            }
            set { }
        }
    }
}
