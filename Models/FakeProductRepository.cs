using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeedMilk.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product> {
new Product { Name = "milk1 %", Price = 25 },
new Product { Name = "Milk 2%", Price = 179 },
new Product { Name = "Half & Half", Price = 95 }
}.AsQueryable<Product>();
    }
}
