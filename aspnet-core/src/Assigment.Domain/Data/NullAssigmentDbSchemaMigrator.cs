using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Assigment.Data;

/* This is used if database provider does't define
 * IAssigmentDbSchemaMigrator implementation.
 */
public class NullAssigmentDbSchemaMigrator : IAssigmentDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
