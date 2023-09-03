﻿using AutoMapper;
using HieuEcommerce.Admin.Manufacturers;
using HieuEcommerce.Admin.ProductAttributes;
using HieuEcommerce.Admin.ProductCategories;
using HieuEcommerce.Admin.Products;
using HieuEcommerce.Manufacturers;
using HieuEcommerce.ProductAttributes;
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
        //Manufacturers
        CreateMap<Manufacturer, ManufacturerDto>();
        CreateMap<Manufacturer, ManufacturerInListDto>();
        CreateMap<CreateUpdateManufacturerDto, Manufacturer>();
        //Product attribute
        CreateMap<ProductAttribute, ProductAttributeDto>();
        CreateMap<ProductAttribute, ProductAttributeInListDto>();
        CreateMap<CreateUpdateProductAttributeDto, ProductAttribute>();

    }
}
