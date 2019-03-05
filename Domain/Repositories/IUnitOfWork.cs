using System.Threading.Tasks;

namespace src.Domain.Repositories
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}