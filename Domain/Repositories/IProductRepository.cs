using System.Collections.Generic;
using System.Threading.Tasks;
using src.Domain.Models;

namespace src.Domain.Repositories
{
    public interface IProductRepository
    {
         Task<IEnumerable<Product>> ListAsync();
    }
}