using TCEcommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TCEcommerce.Permissions;

public class TCEcommercePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TCEcommercePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TCEcommercePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TCEcommerceResource>(name);
    }
}
