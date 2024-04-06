using Volo.Abp.Modularity;

namespace Assigment;

[DependsOn(
    typeof(AssigmentDomainModule),
    typeof(AssigmentTestBaseModule)
)]
public class AssigmentDomainTestModule : AbpModule
{

}
