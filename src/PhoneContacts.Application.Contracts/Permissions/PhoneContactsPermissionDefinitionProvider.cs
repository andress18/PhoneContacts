using PhoneContacts.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace PhoneContacts.Permissions;

public class PhoneContactsPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(PhoneContactsPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(PhoneContactsPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PhoneContactsResource>(name);
    }
}
