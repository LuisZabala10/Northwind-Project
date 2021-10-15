using Northwind.BusinessLogic.Dtos;
using System.Collections.Generic;

namespace Northwind.BusinessLogic.Services.Abstract
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDto> GetAll();
    }
}
