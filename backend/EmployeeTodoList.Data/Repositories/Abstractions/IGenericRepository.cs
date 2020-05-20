using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeTodoList.Data.Repositories.Abstractions
{
    public interface IGenericRepository<TEntity>
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
    }
}