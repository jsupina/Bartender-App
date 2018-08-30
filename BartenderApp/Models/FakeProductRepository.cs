using System.Collections.Generic;
using System.Linq;

namespace BartenderApp.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product> {
         new Product { Name = "Beer", Price = 25 },
         new Product { Name = "Vodka", Price = 179 },
         new Product { Name = "Wine", Price = 95 }
        }.AsQueryable<Product>();
    }
}
