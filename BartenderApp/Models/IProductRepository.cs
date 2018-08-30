using System.Linq;

namespace BartenderApp.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
