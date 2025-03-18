using Data.Repository.DataBase;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Extensions
{
    public static class DBContextExtensions
    {

        public static IServiceCollection DBContextExtension<TContext>(this IServiceCollection servicecollection, IConfiguration configuration)
            where TContext : DbContext
        {
            servicecollection.AddDbContext<TContext>(
                options =>
                {
                    options.UseSqlServer(configuration.GetConnectionString("InventoryDbconnectionString"));
                }
                );
            return servicecollection;
        }
    }
}
