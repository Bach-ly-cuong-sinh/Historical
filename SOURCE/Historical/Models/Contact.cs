using System;
using System.Collections.Generic;

#nullable disable

namespace Historical.Model
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public int IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
