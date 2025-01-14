﻿using Microsoft.AspNetCore.Mvc;
using Northwind.BusinessLogic.Services.Abstract;

namespace Northwind.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_categoryService.GetAll());
        }
    }
}
