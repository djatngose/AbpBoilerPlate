using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpBoilerPlate.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpBoilerPlateEntityFrameworkCoreModule)
        )]
    public class AbpBoilerPlateEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpBoilerPlateMigrationsDbContext>();
        }
    }
}
