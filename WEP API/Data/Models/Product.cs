using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Data.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }
    }
}
