using Northwind.Domain.Entities;
using System.Collections.Generic;

namespace Northwind.DataAccess.Repositories.Abstract
{
    public interface ICategoryRepository
    {
        IEnumerable<Categories> GetAll();
    }
}
