using Entities;
using Entities.Response;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IBaseRepository<Product> _repository;
        private readonly IBaseRepository<ProductDiscount> _repositoryProductDiscount;

        public ProductService(IBaseRepository<Product> repository,
            IBaseRepository<ProductDiscount> repositoryProductDiscount)
        {
            _repository = repository;
            _repositoryProductDiscount = repositoryProductDiscount;
        }

        public async Task<ResponseObject<bool>> AddProductDiscount(ProductDiscount discount)
        {
            try
            {
                var discountInfo = await _repositoryProductDiscount.Where(a => a.ProductId == discount.ProductId && a.DiscountQty == discount.DiscountQty);
                if(discountInfo!= null && discountInfo.Count > 0)
                    _repositoryProductDiscount.Update(discount);
                else
                    await _repositoryProductDiscount.Insert(discount);

                return new ResponseObject<bool>(true, message: "Product added sussefully");
            }
            catch (Exception ex)
            {
                return new ResponseObject<bool>(ex);
            }
        }
        public async Task<ResponseObject<bool>> AddProduct(Product Product)
        {
            try
            {
                await _repository.Insert(Product);
                return new ResponseObject<bool>(true, message: "Product added sussefully");
            }
            catch (Exception ex)
            {
                return new ResponseObject<bool>(ex);
            }
        }
        public async Task<ResponseObject<bool>> DeleteProduct(Guid ProductId)
        {
            try
            {
                var Product = await _repository.GetById(ProductId);
                if (Product != null)
                {
                    _repository.Delete(Product);
                    return new ResponseObject<bool>(true, message: "Product successfully deleted");
                }
                return new ResponseObject<bool>(false, message: "Product not exist");
            }
            catch (Exception ex)
            {
                return new ResponseObject<bool>(ex);
            }
        }
        public async Task<ResponseObject<Product>> GetProduct(Guid ProductId)
        {
            try
            {
                var Product = await _repository.GetById(ProductId);
                if (Product != null)
                    return new ResponseObject<Product>(Product, message: "Product successfully deleted");

                return new ResponseObject<Product>(null, message: "Product not exist");
            }
            catch (Exception ex)
            {
                return new ResponseObject<Product>(ex);
            }
        }
        public async Task<ResponseObject<List<Product>>> GetProducts()
        {
            try
            {
                var Products = await _repository.GetAll();
                if (Products != null && Products.Count > 0)
                    return new ResponseObject<List<Product>>(Products, message: "Product successfully deleted");

                return new ResponseObject<List<Product>>(null, message: "Product not exist");
            }
            catch (Exception ex)
            {
                return new ResponseObject<List<Product>>(ex);
            }
        }
        public async Task<ResponseObject<PagedResponse<List<Product>>>> GetProducts(PaggingInfo info)
        {
            try
            {
                string[] includes = { "Category" };
                var products = await _repository.GetAllSkipTake(info.PageSize, info.PageNumber, includes);
                if (products != null && products.Count > 0)
                {
                    var response = new PagedResponse<List<Product>>()
                    {
                        Data = products,
                        PageNumber = info.PageNumber,
                        PageSize = info.PageSize,
                        TotalRecords = _repository.GetCount()
                    };
                    return new ResponseObject<PagedResponse<List<Product>>>(response, message: "Product successfully deleted");

                }

                return new ResponseObject<PagedResponse<List<Product>>>(null, message: "Product not exist");
            }
            catch (Exception ex)
            {
                return new ResponseObject<PagedResponse<List<Product>>>(ex);
            }
        }

        public async Task<ResponseObject<List<Product>>> GetProductsByCategory(Guid categoryId)
        {
            try
            {
                var Products = await _repository.Where(a=>a.CategoryId == categoryId);
                if (Products != null && Products.Count > 0)
                    return new ResponseObject<List<Product>>(Products, message: "Product successfully deleted");

                return new ResponseObject<List<Product>>(null, message: "Product not exist");
            }
            catch (Exception ex)
            {
                return new ResponseObject<List<Product>>(ex);
            }
        }
        public async Task<ResponseObject<bool>> UpdateProduct(Product Product)
        {
            try
            {
                _repository.Update(Product);
                return new ResponseObject<bool>(true, message: "Product updated successfully");
            }
            catch (Exception ex)
            {
                return new ResponseObject<bool>(ex);
            }
        }
    }

}
