using Assigment.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Assigment.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AssigmentEntityFrameworkCoreModule),
    typeof(AssigmentApplicationContractsModule)
    )]
public class AssigmentDbMigratorModule : AbpModule
{
}
