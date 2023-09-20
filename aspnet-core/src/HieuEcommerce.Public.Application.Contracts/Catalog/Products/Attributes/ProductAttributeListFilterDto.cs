using System;
using System.Collections.Generic;
using System.Text;

namespace HieuEcommerce.Public.Products.Attributes
{
    public class ProductAttributeListFilterDto : BaseListFilterDto
    {
        public Guid ProductId { get; set; }
    }
}
