using Volo.Abp.Modularity;

namespace Assigment;

[DependsOn(
    typeof(AssigmentApplicationModule),
    typeof(AssigmentDomainTestModule)
)]
public class AssigmentApplicationTestModule : AbpModule
{

}
