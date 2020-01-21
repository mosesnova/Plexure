using System;
using System.Collections.Generic;

namespace FrogParkiingCrud.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public byte[] Picture { get; set; }
    }
}
