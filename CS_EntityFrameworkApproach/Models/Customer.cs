using System;
using System.Collections.Generic;

#nullable disable

namespace CS_EntityFrameworkApproach.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }

        public int CustNo { get; set; }
        public string CustName { get; set; }
        public string CustEmail { get; set; }
        public string CustAddress { get; set; }
        public string CustCity { get; set; }
        public string CustState { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
