﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HieuEcommerce.Admin.ProductCategories
{
    public interface IProductCategoriesAppService : ICrudAppService
        <ProductCategoryDto, 
        Guid, 
        PagedResultRequestDto,
        CreateUpdateProductCategoryDto,
        CreateUpdateProductCategoryDto>
    {

    }
}
