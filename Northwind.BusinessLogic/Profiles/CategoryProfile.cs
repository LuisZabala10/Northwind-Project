using AutoMapper;
using Northwind.BusinessLogic.Dtos;
using Northwind.Domain.Entities;

namespace Northwind.BusinessLogic.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Categories, CategoryDto>();
        }
    }
}
