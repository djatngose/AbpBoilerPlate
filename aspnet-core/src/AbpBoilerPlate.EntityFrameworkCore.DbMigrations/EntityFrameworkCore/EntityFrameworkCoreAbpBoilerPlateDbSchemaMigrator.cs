using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpBoilerPlate.Data;
using Volo.Abp.DependencyInjection;

namespace AbpBoilerPlate.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpBoilerPlateDbSchemaMigrator
        : IAbpBoilerPlateDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpBoilerPlateDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpBoilerPlateMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpBoilerPlateMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}