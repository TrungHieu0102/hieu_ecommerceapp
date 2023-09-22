using System;
using HieuEcommerce.Public.Products;

namespace HieuEcommerce.Public.Web.Models
{
    public class CartItem
    {
        public ProductDto Product { get; set; }
        public int Quantity { get; set; }
    }
}