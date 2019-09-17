using System;
using System.Collections.Generic;

namespace Travel_Management_System.Models
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string Pwd { get; set; }
        public string Role { get; set; }
    }
}
