using Volo.Abp.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ABPBoilerplateTeste.Data;

public class ABPBoilerplateTesteDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public ABPBoilerplateTesteDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        
        /* We intentionally resolving the ABPBoilerplateTesteDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ABPBoilerplateTesteDbContext>()
            .Database
            .MigrateAsync();

    }
}
