using AbpBoilerPlate.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpBoilerPlate.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpBoilerPlateEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpBoilerPlateApplicationContractsModule)
        )]
    public class AbpBoilerPlateDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
