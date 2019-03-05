using src.Persistence.Contexts;

namespace src.Persistence.Repositories {
    public abstract class BaseRepository {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context) {
            _context = context;
        }
    }
}