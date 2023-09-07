using HieuEcommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace HieuEcommerce.Public.Permissions;

public class HieuEcommercePublicPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(HieuEcommercePublicPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(PublicPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HieuEcommerceResource>(name);
    }
}
