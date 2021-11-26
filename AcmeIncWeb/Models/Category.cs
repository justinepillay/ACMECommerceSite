using System;
using System.Collections.Generic;

#nullable disable

namespace AcmeIncWeb.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CatId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
