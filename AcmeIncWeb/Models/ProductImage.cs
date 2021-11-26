using System;
using System.Collections.Generic;

#nullable disable

namespace AcmeIncWeb.Models
{
    public partial class ProductImage
    {
        public int ImageId { get; set; }
        public int ProdId { get; set; }
        public string ImageUrl { get; set; }

        public virtual Product Prod { get; set; }
    }
}
