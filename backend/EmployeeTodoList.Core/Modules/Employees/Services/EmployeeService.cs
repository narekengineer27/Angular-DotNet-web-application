using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeTodoList.Core.Modules.Employees.Abstractions;
using EmployeeTodoList.Data.Domains;
using EmployeeTodoList.Data.Repositories.Abstractions;
using EmployeeTodoList.Data.UnitOfWorks;
using Task = System.Threading.Tasks.Task;

namespace EmployeeTodoList.Core.Modules.Employees.Services
{
    internal class EmployeeService:IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork)
        {
            _employeeRepository = employeeRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(Employee model)
        {
            _employeeRepository.Add(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(Employee model)
        {
            _employeeRepository.Update(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(Employee model)
        {
            _employeeRepository.Delete(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return await _employeeRepository.GetAllAsync();
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            return await _employeeRepository.GetByIdAsync(id);
        }
    }
}
