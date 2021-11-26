using System;
using System.Collections.Generic;

#nullable disable

namespace AcmeIncWeb.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public int ProdId { get; set; }

        public virtual Product Prod { get; set; }
        public virtual User User { get; set; }
    }
}
