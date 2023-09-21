using HieuEcommerce.Public.ProductCategories;
using HieuEcommerce.Public.Products;
using System.Collections.Generic;

namespace HieuEcommerce.Public.Web.Models
{
    public class HeaderCacheItem
    {
        public List<ProductCategoryInListDto> Categories { set; get; }
    }
}
