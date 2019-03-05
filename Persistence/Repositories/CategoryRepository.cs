using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using src.Domain.Models;
using src.Domain.Repositories;
using src.Persistence.Contexts;

namespace src.Persistence.Repositories {
    public class CategoryRepository : BaseRepository, ICategoryRepository {
        public CategoryRepository(AppDbContext context) : base(context) { }

        public async Task AddAsync(Category category) {
            await _context.Categories.AddAsync(category);
        }

        public async Task<Category> FindByIdAsync(int id) {
            return await _context.Categories.FindAsync(id);
        }

        public async Task<IEnumerable<Category>> ListAsync() {
            return await _context.Categories.ToListAsync();
        }

        public void Remove(Category category) {
            _context.Categories.Remove(category);
        }

        public void Update(Category category) {
            _context.Categories.Update(category);
        }
    }
}