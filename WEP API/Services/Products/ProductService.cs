using HomeWork.Data;
using HomeWork.Data.Models;
using HomeWork.Models.RequestModels;
using HomeWork.Models.ResultModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Services.Products
{
    public class ProductService : IProductService
    {
        public readonly DataBaseContext Data;

        public ProductService(DataBaseContext context)
        {
            Data = context;
        }

        public async Task<Product> Find(int productId)
        {
            var result = await this.Data.Products.FindAsync(productId);

            return result;
        }

        public async Task<IEnumerable<ProductOutputModel>> GetAllByCategory(int categoryId)
        {
            var Result = await Data.Products
                .Where(w => w.CategoryId == categoryId)
                .Select(s => new ProductOutputModel{})                
               .ToListAsync();

            return Result;
        }

        public async Task<bool> AddProduct(ProductAddModel model)
        {
            await Data.Products.AddAsync(new Product { });

            await Data.SaveChangesAsync();

            return true;
        }

        public async Task<bool> EditProduct(ProductEditModel model)
        {
            var product = Data.Products.FindAsync(model.Id);

            if(product == null)
            {
                // TODO
            }

            // TODO

            await Data.SaveChangesAsync();

            return true;
        }
    }
}
