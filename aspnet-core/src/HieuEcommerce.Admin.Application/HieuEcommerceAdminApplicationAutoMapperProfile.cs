using AutoMapper;
using HieuEcommerce.Admin.Catalog.Manufacturers;
using HieuEcommerce.Admin.Catalog.ProductAttributes;
using HieuEcommerce.Admin.Catalog.ProductCategories;
using HieuEcommerce.Admin.Catalog.Products;
using HieuEcommerce.Admin.System.Roles;
using HieuEcommerce.Admin.System.Users;
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
        //User
        CreateMap<IdentityUser, UserDto>();
        CreateMap<IdentityUser, UserInListDto>();
    }

}
 
