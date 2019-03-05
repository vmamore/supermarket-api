using System.Collections.Generic;
using System.Threading.Tasks;
using src.Domain.Models;
using src.Domain.Repositories;
using src.Domain.Services;

namespace src.Services {
    public class ProductService : IProductService {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository) {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> ListAsync() {
            return await _productRepository.ListAsync();
        }
    }
}