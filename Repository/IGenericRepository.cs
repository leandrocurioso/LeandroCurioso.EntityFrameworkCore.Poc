using System.Linq;
using System.Threading.Tasks;
using LeandroCurioso.EntityFrameworkCore.Poc.Models;

namespace LeandroCurioso.EntityFrameworkCore.Poc.Repository
{
    public interface IGenericRepository<TEntity>
        where TEntity : Entity
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(int id);
        Task Create(TEntity entity);
        Task Update(int id, TEntity entity);
        Task Delete(int id);
    }
}
