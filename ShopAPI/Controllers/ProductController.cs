using AutoMapper;
using Entities;
using Entities.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.ProductService;
using ShopAPI.Models;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Controllers
{
    [ApiController]
    [Route("api/Product")]
    [Authorize]
    [SwaggerTag("Product controller")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        private readonly IServiceProvider _serviceProvider;
        public ProductController(IServiceProvider serviceProvider, IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
            _serviceProvider = serviceProvider;
        }

        [HttpPost]
        public async Task<ResponseObject<bool>> Add(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            var result = await _productService.AddProduct(product);
            return _mapper.Map<ResponseObject<bool>>(result);
        }

        [HttpPost("Discount")]
        public async Task<ResponseObject<bool>> AddProductDiscount(ProductDiscountDto productDiscountDto)
        {
            var productDiscount = _mapper.Map<ProductDiscount>(productDiscountDto);
            var result = await _productService.AddProductDiscount(productDiscount);
            return _mapper.Map<ResponseObject<bool>>(result);
        }

        [HttpPost("PaggedProducts")]
        public async Task<ResponseObject<PaggedResponseModel<List<ProductDto>>>> GetPaggedProducts(PaggingFilter filter)
        {
            var info = _mapper.Map<PaggingInfo>(filter);
            var result = await _productService.GetProducts(info);
            return _mapper.Map<ResponseObject<PaggedResponseModel<List<ProductDto>>>>(result);
        }


        [HttpGet("{productId}")]
        public async Task<ResponseObject<ProductDto>> Get(Guid productId)
        {
            var result = await _productService.GetProduct(productId);
            return _mapper.Map<ResponseObject<ProductDto>>(result);
        }

        [HttpGet]
        public async Task<ResponseObject<List<ProductDto>>> GetAll()
        {
            var result = await _productService.GetProducts();
            return _mapper.Map<ResponseObject<List<ProductDto>>>(result);
        }

        [HttpGet("Category/{categoryId}")]
        public async Task<ResponseObject<List<ProductDto>>> GetByCategoryId(Guid categoryId)
        {
            var result = await _productService.GetProductsByCategory(categoryId);
            return _mapper.Map<ResponseObject<List<ProductDto>>>(result);
        }


        [HttpDelete("{productId}")]
        public async Task<ResponseObject<bool>> Delete(Guid productId)
        {
            var result = await _productService.DeleteProduct(productId);
            return _mapper.Map<ResponseObject<bool>>(result);
        }

        [HttpPut]
        public async Task<ResponseObject<bool>> Put(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            var result = await _productService.UpdateProduct(product);
            return _mapper.Map<ResponseObject<bool>>(result);
        }
    }
}
