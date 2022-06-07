using System;
using System.Collections.Generic;

#nullable disable

namespace CoreAPI.Models
{
    public partial class Orders
    {
        public int OrderNo { get; set; }
        public string OrderItem { get; set; }
        public string OrderDate { get; set; }
        public int OrderQuantity { get; set; }
        public int CustNo { get; set; }

        public virtual Customer CustNoNavigation { get; set; }
    }
}
