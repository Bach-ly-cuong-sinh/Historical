using System;
using System.Collections.Generic;

#nullable disable

namespace Historical.Model
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IsActive { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
