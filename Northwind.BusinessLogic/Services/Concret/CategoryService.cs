using AutoMapper;
using Northwind.BusinessLogic.Dtos;
using Northwind.BusinessLogic.Services.Abstract;
using Northwind.DataAccess.Repositories.Abstract;
using System.Collections.Generic;

namespace Northwind.BusinessLogic.Services.Concret
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public IEnumerable<CategoryDto> GetAll()
        {
            var categories = _categoryRepository.GetAll();

            return _mapper.Map<IEnumerable<CategoryDto>>(categories);
        }
    }
}
