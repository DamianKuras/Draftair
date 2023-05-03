using Draftair.DAL.Factories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Draftair.DAL.Startup
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDataAccessServices(
            this IServiceCollection services,
            string connectionString
        )
        {
            services.AddDbContext<CMSDBContext>(options => options.UseSqlite(connectionString));
            services.AddSingleton<IDbConnectionFactory>(
                new SqliteDbConnectionFactory(connectionString)
            );
        }
    }
}
