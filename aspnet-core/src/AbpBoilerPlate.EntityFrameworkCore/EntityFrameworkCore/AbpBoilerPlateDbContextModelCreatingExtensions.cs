using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AbpBoilerPlate.EntityFrameworkCore
{
    public static class AbpBoilerPlateDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpBoilerPlate(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpBoilerPlateConsts.DbTablePrefix + "YourEntities", AbpBoilerPlateConsts.DbSchema);

            //    //...
            //});
        }
    }
}