using HieuEcommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace HieuEcommerce.Admin.Permissions;

public class HieuEcommercePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        //Catalog
        var catalogGroup = context.AddGroup(HieuEcommercePermissions.CatalogGroupName, L("Permission:Catalog"));

       

        //Add product
        var productPermission = catalogGroup.AddPermission(HieuEcommercePermissions.Product.Default, L("Permission:Catalog.Product"));
        productPermission.AddChild(HieuEcommercePermissions.Product.Create, L("Permission:Catalog.Product.Create"));
        productPermission.AddChild(HieuEcommercePermissions.Product.Update, L("Permission:Catalog.Product.Update"));
        productPermission.AddChild(HieuEcommercePermissions.Product.Delete, L("Permission:Catalog.Product.Delete"));
        productPermission.AddChild(HieuEcommercePermissions.Product.AttributeManage, L("Permission:Catalog.Product.AttributeManage"));
        //Manufacture
        var manufacturerPermission = catalogGroup.AddPermission(HieuEcommercePermissions.Manufacturer.Default, L("Permission:Catalog.Manufacturer"));
        manufacturerPermission.AddChild(HieuEcommercePermissions.Manufacturer.Create, L("Permission:Catalog.Manufacturer.Create"));
        manufacturerPermission.AddChild(HieuEcommercePermissions.Manufacturer.Update, L("Permission:Catalog.Manufacturer.Update"));
        manufacturerPermission.AddChild(HieuEcommercePermissions.Manufacturer.Delete, L("Permission:Catalog.Manufacturer.Delete"));

        //Product Category
        var productCategoryPermission = catalogGroup.AddPermission(HieuEcommercePermissions.ProductCategory.Default, L("Permission:Catalog.ProductCategory"));
        productCategoryPermission.AddChild(HieuEcommercePermissions.ProductCategory.Create, L("Permission:Catalog.ProductCategory.Create"));
        productCategoryPermission.AddChild(HieuEcommercePermissions.ProductCategory.Update, L("Permission:Catalog.ProductCategory.Update"));
        productCategoryPermission.AddChild(HieuEcommercePermissions.ProductCategory.Delete, L("Permission:Catalog.ProductCategory.Delete"));
        //Add attribute
        var attributePermission = catalogGroup.AddPermission(HieuEcommercePermissions.Attribute.Default, L("Permission:Catalog.Attribute"));
        attributePermission.AddChild(HieuEcommercePermissions.Attribute.Create, L("Permission:Catalog.Attribute.Create"));
        attributePermission.AddChild(HieuEcommercePermissions.Attribute.Update, L("Permission:Catalog.Attribute.Update"));
        attributePermission.AddChild(HieuEcommercePermissions.Attribute.Delete, L("Permission:Catalog.Attribute.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HieuEcommerceResource>(name);
    }
}
