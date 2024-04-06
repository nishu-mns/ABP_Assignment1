using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Assigment.Data;
using Volo.Abp.DependencyInjection;

namespace Assigment.EntityFrameworkCore;

public class EntityFrameworkCoreAssigmentDbSchemaMigrator
    : IAssigmentDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAssigmentDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the AssigmentDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AssigmentDbContext>()
            .Database
            .MigrateAsync();
    }
}
