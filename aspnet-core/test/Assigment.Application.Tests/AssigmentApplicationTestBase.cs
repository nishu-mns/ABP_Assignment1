using Volo.Abp.Modularity;

namespace Assigment;

public abstract class AssigmentApplicationTestBase<TStartupModule> : AssigmentTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
