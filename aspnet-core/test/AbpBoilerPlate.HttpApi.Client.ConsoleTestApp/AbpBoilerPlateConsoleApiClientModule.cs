using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AbpBoilerPlate.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(AbpBoilerPlateHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AbpBoilerPlateConsoleApiClientModule : AbpModule
    {
        
    }
}
