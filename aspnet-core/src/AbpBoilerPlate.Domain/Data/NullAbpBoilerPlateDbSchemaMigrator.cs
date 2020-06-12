using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpBoilerPlate.Data
{
    /* This is used if database provider does't define
     * IAbpBoilerPlateDbSchemaMigrator implementation.
     */
    public class NullAbpBoilerPlateDbSchemaMigrator : IAbpBoilerPlateDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}