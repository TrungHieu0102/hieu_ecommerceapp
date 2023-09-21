using HieuEcommerce.Public.ProductCategories;
using HieuEcommerce.Public.Products;
using System.Collections.Generic;

namespace HieuEcommerce.Public.Web.Models
{
    public class HomeCacheItem
    {
        public List<ProductCategoryInListDto> Categories { set; get; }
        public List<ProductInListDto> TopSellerProducts { set; get; }
    }
}
