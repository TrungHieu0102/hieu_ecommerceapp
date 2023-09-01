using AutoMapper;
using HieuEcommerce.Admin.ProductCategories;
using HieuEcommerce.Admin.Products;
using HieuEcommerce.ProductCategories;
using HieuEcommerce.Products;

namespace HieuEcommerce.Admin;

public class HieuEcommerceAdminApplicationAutoMapperProfile : Profile
{
    public HieuEcommerceAdminApplicationAutoMapperProfile()
    {
        //PRODUCT CATEGORY
       CreateMap<ProductCategory, ProductCategoryDto>();
       CreateMap<ProductCategory, ProductCategoryInListDto>();
       CreateMap<CreateUpdateProductCategoryDto, ProductCategory>();
        //PRODUCT
        CreateMap<Product, ProductDto>();
        CreateMap<Product, ProductInListDto>();
        CreateMap<CreateUpdateProductDto, Product>();

    }
}
