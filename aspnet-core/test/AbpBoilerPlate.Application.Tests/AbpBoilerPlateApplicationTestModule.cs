using Volo.Abp.Modularity;

namespace AbpBoilerPlate
{
    [DependsOn(
        typeof(AbpBoilerPlateApplicationModule),
        typeof(AbpBoilerPlateDomainTestModule)
        )]
    public class AbpBoilerPlateApplicationTestModule : AbpModule
    {

    }
}