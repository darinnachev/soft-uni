using HomeWork.Data.Models;
using HomeWork.Models.ResultModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Services.Categories
{
    public interface ICategoryService
    {
        Task<Category> Find(int categoryId);

        Task<IEnumerable<CategoryOutputModel>> GetAll();
    }
}
