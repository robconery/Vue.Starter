using System;
using System.Collections.Generic;

namespace Vue.Starter.Data.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Last{ get; set; }
        public string First { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}