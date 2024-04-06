using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Identity;
using Volo.Abp.PermissionManagement;
using Assigment.Permissions;

namespace Assigment
{
    public class AddUsersDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IdentityRoleManager _identityRoleManager;
        private readonly IPermissionManager _permissionManager;

        public AddUsersDataSeederContributor(IdentityRoleManager identityRoleManager, IPermissionManager permissionManager)
        {
            _identityRoleManager = identityRoleManager;
            _permissionManager = permissionManager;
        }

            public async Task SeedAsync(DataSeedContext context) {

            //check role exist
            var roleExist = await _identityRoleManager.FindByNameAsync("HR");
            if (roleExist == null)
            {
                await _identityRoleManager.CreateAsync(new IdentityRole(Guid.NewGuid(), "HR"));
            }

            await _permissionManager.SetForRoleAsync("HR", AssigmentPermissions.Employees.Default, true);
            await _permissionManager.SetForRoleAsync("HR", AssigmentPermissions.Employees.Create, true);
            await _permissionManager.SetForRoleAsync("HR", AssigmentPermissions.Employees.Edit, true);
            await _permissionManager.SetForRoleAsync("HR", AssigmentPermissions.Employees.Delete, true);

        }
    }
}
