using HomeWork.Data;
using HomeWork.Data.Models;
using HomeWork.Models.ResultModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        public readonly DataBaseContext Data;

        public CategoryService(DataBaseContext context)
        {
            Data = context;
        }

        public async Task<Category> Find(int categoryId)
        {
            var result = await this.Data.Categories.FindAsync(categoryId);

            return result;
        }

        public async Task<IEnumerable<CategoryOutputModel>> GetAll()
        {
            var Result = await Data.Categories.Select( s => new CategoryOutputModel 
            { Id = s.Id, Description = s.Description, Name = s.Name})
                .ToListAsync();

            return Result;
        }
    }
}
