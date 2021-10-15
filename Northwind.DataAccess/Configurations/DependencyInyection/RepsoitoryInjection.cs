using Microsoft.Extensions.DependencyInjection;
using Northwind.DataAccess.Repositories.Abstract;
using Northwind.DataAccess.Repositories.Concret;

namespace Northwind.DataAccess.Configurations.DependencyInyection
{
    public static class RepsoitoryInjection
    {
        public static void RepositoryInjections(this IServiceCollection services)
        {
            services.AddTransient<ICategoryRepository, CategoryRepository>();
        }
    }
}
