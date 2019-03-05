using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using src.Domain.Models;
using src.Domain.Repositories;
using src.Persistence.Contexts;

namespace src.Persistence.Repositories {
    public class ProductRepository : BaseRepository, IProductRepository {
        public ProductRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Product>> ListAsync() {
            return await _context.Products.Include(p => p.Category)
                .ToListAsync();
        }
    }
}