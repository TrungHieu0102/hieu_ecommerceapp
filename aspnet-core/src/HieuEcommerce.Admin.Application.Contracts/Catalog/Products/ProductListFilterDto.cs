﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HieuEcommerce.Admin.Catalog.Products
{
    public class ProductListFilterDto : BaseListFilterDto
    {
        public Guid? CategoryId { get; set; }
    }
}
