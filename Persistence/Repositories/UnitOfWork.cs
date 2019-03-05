using System.Threading.Tasks;
using src.Domain.Repositories;
using src.Persistence.Contexts;

namespace src.Persistence.Repositories {
    public class UnitOfWork : IUnitOfWork {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context) {
            _context = context;
        }

        public async Task CompleteAsync() {
            await _context.SaveChangesAsync();
        }
    }
}