namespace Assigment.Permissions;

public static class AssigmentPermissions
{
    public const string GroupName = "Assigment";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";

    public static class Employees
    {
        public const string Default = GroupName + ".Employees";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
