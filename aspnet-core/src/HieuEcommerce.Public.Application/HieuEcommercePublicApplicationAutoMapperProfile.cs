using AutoMapper;
using HieuEcommerce.Manufacturers;
using HieuEcommerce.Orders;
using HieuEcommerce.ProductAttributes;
using HieuEcommerce.ProductCategories;
using HieuEcommerce.Products;
using HieuEcommerce.Public.Manufacturers;
using HieuEcommerce.Public.Orders;
using HieuEcommerce.Public.ProductAttributes;
using HieuEcommerce.Public.ProductCategories;
using HieuEcommerce.Public.Products;

namespace HieuEcommerce.Public;

public class HieuEcommercePublicApplicationAutoMapperProfile : Profile
{
    public HieuEcommercePublicApplicationAutoMapperProfile()
    {
        //Product Category
        CreateMap<ProductCategory, ProductCategoryDto>();
        CreateMap<ProductCategory, ProductCategoryInListDto>();

        //Product
        CreateMap<Product, ProductDto>();
        CreateMap<Product, ProductInListDto>();

        CreateMap<Manufacturer, ManufacturerDto>();
        CreateMap<Manufacturer, ManufacturerInListDto>();

        //Product attribute
        CreateMap<ProductAttribute, ProductAttributeDto>();
        CreateMap<ProductAttribute, ProductAttributeInListDto>();

        //Order
        CreateMap<Order, OrderDto>();
    }
}
