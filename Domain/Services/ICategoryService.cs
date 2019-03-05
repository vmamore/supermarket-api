using System.Collections.Generic;
using System.Threading.Tasks;
using src.Domain.Models;
using src.Domain.Services.Communication;

namespace src.Domain.Services {
    public interface ICategoryService {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);
    }
}