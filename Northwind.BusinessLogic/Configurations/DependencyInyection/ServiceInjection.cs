using Microsoft.Extensions.DependencyInjection;
using Northwind.BusinessLogic.Services.Abstract;
using Northwind.BusinessLogic.Services.Concret;

namespace Northwind.BusinessLogic.Configurations.DependencyInyection
{
    public static class ServiceInjection
    {
        public static void ServiceInjections(this IServiceCollection services)
        {
            services.AddTransient<ICategoryService, CategoryService>();
        }
    }
}
