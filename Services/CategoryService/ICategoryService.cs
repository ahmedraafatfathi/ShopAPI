using Entities;
using Entities.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.CategoryService
{
    public interface ICategoryService
    {
        Task<ResponseObject<bool>> AddCategory(Category Category);
        Task<ResponseObject<bool>> UpdateCategory(Category Category);
        Task<ResponseObject<bool>> DeleteCategory(Guid CategoryId);
        Task<ResponseObject<List<Category>>> GetCategories();
        Task<ResponseObject<Category>> GetCategory(Guid CategoryId);
    }
}
