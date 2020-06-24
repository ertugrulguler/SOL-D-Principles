using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.SingleResponsibility.Models
{
    public class Adress
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
