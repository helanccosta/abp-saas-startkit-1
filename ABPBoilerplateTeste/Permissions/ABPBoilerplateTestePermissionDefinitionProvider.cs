using ABPBoilerplateTeste.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ABPBoilerplateTeste.Permissions;

public class ABPBoilerplateTestePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ABPBoilerplateTestePermissions.GroupName);

        var booksPermission = myGroup.AddPermission(ABPBoilerplateTestePermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(ABPBoilerplateTestePermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(ABPBoilerplateTestePermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(ABPBoilerplateTestePermissions.Books.Delete, L("Permission:Books.Delete"));

        //Define your own permissions here. Example:
        //myGroup.AddPermission(ABPBoilerplateTestePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ABPBoilerplateTesteResource>(name);
    }
}
