using System.Threading.Tasks;
using EmployeeTodoList.Data.Context;

namespace EmployeeTodoList.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeTodoListContext _context;

        public UnitOfWork(EmployeeTodoListContext context)
        {
            _context = context;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
