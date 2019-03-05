using System.Collections.Generic;
using System.Threading.Tasks;
using src.Domain.Models;

namespace src.Domain.Services
{
    public interface IProductService
    {
         Task<IEnumerable<Product>> ListAsync();
    }
}