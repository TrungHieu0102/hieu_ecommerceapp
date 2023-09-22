using HieuEcommerce.Public.Products.Attributes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HieuEcommerce.Public.Products
{
    public interface IProductAppService : IReadOnlyAppService
        <ProductDto,
        Guid,
        PagedResultRequestDto>
    {
        Task<PagedResult<ProductInListDto>> GetListFilterAsync(ProductListFilterDto input);
        Task<List<ProductInListDto>> GetListAllAsync();
        Task<string> GetThumbnailImageAsync(string fileName);
        Task<List<ProductAttributeValueDto>> GetListProductAttributeAllAsync(Guid productId);
        Task<PagedResult<ProductAttributeValueDto>> GetListProductAttributesAsync(ProductAttributeListFilterDto input);
        Task<List<ProductInListDto>> GetListTopSellerAllAsync(int numberOfRecords);
        Task<ProductDto> GetBySlugAsync(string slug);
    }
}
