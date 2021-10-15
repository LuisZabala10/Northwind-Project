using Northwind.DataAccess.Contexts;
using Northwind.DataAccess.Repositories.Abstract;
using Northwind.Domain.Entities;
using System.Collections.Generic;

namespace Northwind.DataAccess.Repositories.Concret
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly NorthwindContext _northwindContext;

        public CategoryRepository(NorthwindContext northwindContext)
        {
            _northwindContext = northwindContext;
        }
        public IEnumerable<Categories> GetAll()
        {
            return _northwindContext.Categories;
        }
    }
}
