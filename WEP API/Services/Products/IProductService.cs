using HomeWork.Data.Models;
using HomeWork.Models.RequestModels;
using HomeWork.Models.ResultModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Services.Products
{
    public interface IProductService
    {
        Task<Product> Find(int productId);

        Task<IEnumerable<ProductOutputModel>> GetAllByCategory(int categoryId);

        Task<bool> AddProduct(ProductAddModel model);

        Task<bool> EditProduct(ProductEditModel model);
    }
}
