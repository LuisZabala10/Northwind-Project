using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Northwind.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Configurations.DependencyInyection
{
    public static class ContextInyection
    {
        public static void ContextInyections(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NorthwindContext>(options => options.UseSqlServer(configuration.GetConnectionString("NorthwindDb")));
        }
    }
}
