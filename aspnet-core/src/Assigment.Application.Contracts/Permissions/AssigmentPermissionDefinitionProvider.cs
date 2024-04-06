using Assigment.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Assigment.Permissions;

public class AssigmentPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        //var myGroup = context.AddGroup(AssigmentPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AssigmentPermissions.MyPermission1, L("Permission:MyPermission1"));

        var assignmentGroup = context.AddGroup(AssigmentPermissions.GroupName, L("Permission:Assigment"));

        var assigmentPermission = assignmentGroup.AddPermission(AssigmentPermissions.Employees.Default, L("Permission:Employees"));
        assigmentPermission.AddChild(AssigmentPermissions.Employees.Create, L("Permission:Employees.Create"));
        assigmentPermission.AddChild(AssigmentPermissions.Employees.Edit, L("Permission:Employees.Edit"));
        assigmentPermission.AddChild(AssigmentPermissions.Employees.Delete, L("Permission:Employees.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AssigmentResource>(name);
    }
}
