using Entities;
using Entities.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.ProductService
{
    public interface IProductService
    {
        Task<ResponseObject<bool>> AddProductDiscount(ProductDiscount discount);
        Task<ResponseObject<bool>> AddProduct(Product Product);
        Task<ResponseObject<bool>> UpdateProduct(Product Product);
        Task<ResponseObject<bool>> DeleteProduct(Guid ProductId);
        Task<ResponseObject<List<Product>>> GetProducts();
        Task<ResponseObject<PagedResponse<List<Product>>>> GetProducts(PaggingInfo info);
        Task<ResponseObject<Product>> GetProduct(Guid ProductId);
        Task<ResponseObject<List<Product>>> GetProductsByCategory(Guid categoryId);

    }
}
