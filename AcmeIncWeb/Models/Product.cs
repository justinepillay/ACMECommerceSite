using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace AcmeIncWeb.Models
{
    public partial class Product
    {
        public Product()
        {
            Carts = new HashSet<Cart>();
            Orders = new HashSet<Order>();
            ProductImages = new HashSet<ProductImage>();
        }

        public int ProdId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        [Display(Name = "Price")]
        public decimal? Sell { get; set; }
        public int? CatId { get; set; }

        [Display(Name = "Product")]
        public string ImageUrl { get; set; }

        [Display(Name = "Category")]
        public virtual Category Cat { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}
