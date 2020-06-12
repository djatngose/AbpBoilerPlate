using System.Threading.Tasks;

namespace AbpBoilerPlate.Data
{
    public interface IAbpBoilerPlateDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
