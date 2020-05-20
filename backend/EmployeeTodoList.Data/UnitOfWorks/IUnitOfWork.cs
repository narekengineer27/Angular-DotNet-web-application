using System.Threading.Tasks;

namespace EmployeeTodoList.Data.UnitOfWorks
{
    public interface IUnitOfWork
    {
        void SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
