using Volo.Abp.Modularity;

namespace Assigment;

/* Inherit from this class for your domain layer tests. */
public abstract class AssigmentDomainTestBase<TStartupModule> : AssigmentTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
