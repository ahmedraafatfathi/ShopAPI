using Entities;
using Entities.Response;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.CategoryService
{
    

    public class CategoryService : ICategoryService
    {
        private readonly IBaseRepository<Category> _repository;
        public CategoryService(IBaseRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<ResponseObject<bool>> AddCategory(Category Category)
        {
            try
            {
                 await _repository.Insert(Category);

                return new ResponseObject<bool>(true, message: "Category added sussefully");
            }
            catch (Exception ex)
            {
                return new ResponseObject<bool>(ex);
            }
        }
        public async Task<ResponseObject<bool>> DeleteCategory(Guid CategoryId)
        {
            try
            {
                var Category = await _repository.GetById(CategoryId);
                if (Category != null)
                {
                    _repository.Delete(Category);
                    return new ResponseObject<bool>(true, message: "Category successfully deleted");
                }
                return new ResponseObject<bool>(false, message: "Category not exist");
            }
            catch (Exception ex)
            {
                return new ResponseObject<bool>(ex);
            }
        }
        public async Task<ResponseObject<Category>> GetCategory(Guid CategoryId)
        {
            try
            {
                var Category = await _repository.GetById(CategoryId);
                if (Category != null)
                    return new ResponseObject<Category>(Category, message: "Category successfully deleted");

                return new ResponseObject<Category>(null, message: "Category not exist");
            }
            catch (Exception ex)
            {
                return new ResponseObject<Category>(ex);
            }
        }
        public async Task<ResponseObject<List<Category>>> GetCategories()
        {
            try
            {
                var Categorys = await _repository.GetAll();
                if (Categorys != null && Categorys.Count > 0)
                    return new ResponseObject<List<Category>>(Categorys, message: "Category successfully deleted");

                return new ResponseObject<List<Category>>(null, message: "Category not exist");
            }
            catch (Exception ex)
            {
                return new ResponseObject<List<Category>>(ex);
            }
        }
        public async Task<ResponseObject<bool>> UpdateCategory(Category Category)
        {
            try
            {
                _repository.Update(Category);
                return new ResponseObject<bool>(true, message: "Category updated successfully");
            }
            catch (Exception ex)
            {
                return new ResponseObject<bool>(ex);
            }
        }
    }

}
