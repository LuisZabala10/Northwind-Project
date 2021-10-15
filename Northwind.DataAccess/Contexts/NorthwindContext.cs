using Microsoft.EntityFrameworkCore;
using Northwind.Domain.Entities;

namespace Northwind.DataAccess.Contexts
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options)
        {

        }

        public DbSet<Categories> Categories { get; set; }
    }
}
