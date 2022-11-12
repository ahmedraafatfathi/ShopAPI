using AutoMapper;
using Entities;
using Entities.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.CategoryService;
using ShopAPI.Models;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Controllers
{

    [ApiController]
    [Route("api/Category")]
    [Authorize]
    [SwaggerTag("Category controller")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        private readonly IServiceProvider _serviceProvider;
        public CategoryController(IServiceProvider serviceProvider, ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
            _serviceProvider = serviceProvider;
        }

        [HttpPost]
        public async Task<ResponseObject<bool>> Add(CategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            var result = await _categoryService.AddCategory(category);
            return _mapper.Map<ResponseObject<bool>>(result);
        }

        [HttpGet("{categoryId}")]
        public async Task<ResponseObject<CategoryDto>> Get(Guid categoryId)
        {
            var result = await _categoryService.GetCategory(categoryId);
            return _mapper.Map<ResponseObject<CategoryDto>>(result);
        }

        [HttpGet]
        public async Task<ResponseObject<List<CategoryDto>>> GetAll()
        {
            var result = await _categoryService.GetCategories();
            return _mapper.Map<ResponseObject<List<CategoryDto>>>(result);
        }

        [HttpDelete("{categoryId}")]
        public async Task<ResponseObject<bool>> Delete(Guid categoryId)
        {
            var result = await _categoryService.DeleteCategory(categoryId);
            return _mapper.Map<ResponseObject<bool>>(result);
        }

        [HttpPut]
        public async Task<ResponseObject<bool>> Put(CategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            var result = await _categoryService.UpdateCategory(category);
            return _mapper.Map<ResponseObject<bool>>(result);
        }
    }
}
