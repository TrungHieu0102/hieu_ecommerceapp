﻿using HieuEcommerce.Admin.Permissions;
using HieuEcommerce.ProductCategories;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HieuEcommerce.Admin.Catalog.ProductCategories
{
    [Authorize(HieuEcommercePermissions.ProductCategory.Default, Policy = "AdminOnly")]
    public class ProductCategoriesAppService : CrudAppService<
         ProductCategory,
         ProductCategoryDto,
         Guid,
         PagedResultRequestDto,
         CreateUpdateProductCategoryDto,
         CreateUpdateProductCategoryDto>, IProductCategoriesAppService
    {
        public ProductCategoriesAppService(IRepository<ProductCategory, Guid> repository)
            : base(repository)
        {
            GetPolicyName = HieuEcommercePermissions.ProductCategory.Default;
            GetListPolicyName = HieuEcommercePermissions.ProductCategory.Default;
            CreatePolicyName = HieuEcommercePermissions.ProductCategory.Create;
            UpdatePolicyName = HieuEcommercePermissions.ProductCategory.Update;
            DeletePolicyName = HieuEcommercePermissions.ProductCategory.Delete;
        }

        [Authorize(HieuEcommercePermissions.ProductCategory.Delete)]

        public async Task DeleteMultipleAsync(IEnumerable<Guid> ids)
        {
            await Repository.DeleteManyAsync(ids);
            await UnitOfWorkManager.Current.SaveChangesAsync();
        }

        [Authorize(HieuEcommercePermissions.ProductCategory.Default)]

        public async Task<List<ProductCategoryInListDto>> GetListAllAsync()
        {
            var query = await Repository.GetQueryableAsync();
            query = query.Where(x => x.IsActive == true);
            var data = await AsyncExecuter.ToListAsync(query);

            return ObjectMapper.Map<List<ProductCategory>, List<ProductCategoryInListDto>>(data);

        }

        [Authorize(HieuEcommercePermissions.ProductCategory.Default)]

        public async Task<PagedResultDto<ProductCategoryInListDto>> GetListFilterAsync(BaseListFilterDto input)
        {
            var query = await Repository.GetQueryableAsync();
            query = query.WhereIf(!string.IsNullOrWhiteSpace(input.Keyword), x => x.Name.Contains(input.Keyword));

            var totalCount = await AsyncExecuter.LongCountAsync(query);
            var data = await AsyncExecuter.ToListAsync(query.Skip(input.SkipCount).Take(input.MaxResultCount));

            return new PagedResultDto<ProductCategoryInListDto>(totalCount, ObjectMapper.Map<List<ProductCategory>, List<ProductCategoryInListDto>>(data));
        }
    }
}
