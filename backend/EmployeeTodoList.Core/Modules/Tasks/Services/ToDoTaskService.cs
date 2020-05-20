using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeTodoList.Core.Modules.Tasks.Abstractions;
using EmployeeTodoList.Data.Domains;
using EmployeeTodoList.Data.Repositories.Abstractions;
using EmployeeTodoList.Data.UnitOfWorks;

namespace EmployeeTodoList.Core.Modules.Tasks.Services
{
    internal class ToDoTaskService: IToDoTaskService
    {
        private readonly IToDoTaskRepository _toDoTaskRepository;
        private readonly IUnitOfWork _unitOfWork;
        public ToDoTaskService(IToDoTaskRepository toDoTaskRepository, IUnitOfWork unitOfWork)
        {
            _toDoTaskRepository = toDoTaskRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(ToDoTask model)
        {
            _toDoTaskRepository.Add(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(ToDoTask model)
        {
            _toDoTaskRepository.Update(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(ToDoTask model)
        {
            _toDoTaskRepository.Delete(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public  async Task<List<ToDoTask>> GetAllAsync()
        {
            return await _toDoTaskRepository.GetAllAsync();
        }

        public async Task<ToDoTask> GetByIdAsync(int id)
        {
            return await _toDoTaskRepository.GetByIdAsync(id);
        }
    }
}
