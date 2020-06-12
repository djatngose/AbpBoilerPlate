using AbpBoilerPlate.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpBoilerPlate
{
    [DependsOn(
        typeof(AbpBoilerPlateEntityFrameworkCoreTestModule)
        )]
    public class AbpBoilerPlateDomainTestModule : AbpModule
    {

    }
}