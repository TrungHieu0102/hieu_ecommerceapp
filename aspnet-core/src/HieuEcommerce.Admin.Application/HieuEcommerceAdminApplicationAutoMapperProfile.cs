using AutoMapper;
using HieuEcommerce.Admin.Manufacturers;
using HieuEcommerce.Admin.ProductAttributes;
using HieuEcommerce.Admin.ProductCategories;
using HieuEcommerce.Admin.Products;
using HieuEcommerce.Admin.Roles;
using HieuEcommerce.Manufacturers;
using HieuEcommerce.ProductAttributes;
using HieuEcommerce.ProductCategories;
using HieuEcommerce.Products;
using HieuEcommerce.Roles;
using Volo.Abp.Identity;

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
        //Manufacturers
        CreateMap<Manufacturer, ManufacturerDto>();
        CreateMap<Manufacturer, ManufacturerInListDto>();
        CreateMap<CreateUpdateManufacturerDto, Manufacturer>();
        //Product attribute
        CreateMap<ProductAttribute, ProductAttributeDto>();
        CreateMap<ProductAttribute, ProductAttributeInListDto>();
        CreateMap<CreateUpdateProductAttributeDto, ProductAttribute>();
        //Roles
        CreateMap<IdentityRole, RoleDto>().ForMember(x => x.Description,
            map => map.MapFrom(x => x.ExtraProperties.ContainsKey(RoleConsts.DescriptionFieldName)
            ?
            x.ExtraProperties[RoleConsts.DescriptionFieldName]
            :
            null));
        CreateMap<IdentityRole, RoleInListDto>().ForMember(x => x.Description,
            map => map.MapFrom(x => x.ExtraProperties.ContainsKey(RoleConsts.DescriptionFieldName)
            ?
            x.ExtraProperties[RoleConsts.DescriptionFieldName]
            :
            null));
        CreateMap<CreateUpdateRoleDto, IdentityRole>();
    }

}
 
