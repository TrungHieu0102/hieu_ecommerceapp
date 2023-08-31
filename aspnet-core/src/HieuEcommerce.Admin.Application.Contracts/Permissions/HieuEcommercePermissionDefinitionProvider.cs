using HieuEcommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace HieuEcommerce.Admin.Permissions;

public class HieuEcommercePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(HieuEcommercePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(HieuEcommercePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HieuEcommerceResource>(name);
    }
}
