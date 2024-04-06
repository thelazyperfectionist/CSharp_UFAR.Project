using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagmentSystem.Data
{
    public class EmployeeService
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Employee> GetEmployeeAsync(int id)
        {
            try
            {
                return await _appDbContext.Employee.FirstOrDefaultAsync(e => e.Id == id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            try
            {
                return await _appDbContext.Employee.ToListAsync();
            }
            catch (Exception ex)
            {
                return new List<Employee>();
            }
        }

        public async Task<List<Employee>> GetAllMaleFemaleEmployeesAsync(string gender)
        {
            try
            {
                return await _appDbContext.Employee.Where(e => e.Gender == gender).ToListAsync();
            }
            catch (Exception ex)
            {
                return new List<Employee>();
            }
        }

        public async Task<bool> InsertEmployeeAsync(Employee employee)
        {
            try
            {
                await _appDbContext.Employee.AddAsync(employee);
                await _appDbContext.SaveChangesAsync();

                return employee.Id > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<decimal> GetAverageSalaryAsync()
        {
            try
            {
                var salaries = await _appDbContext.Employee.Select(e => e.Salary).ToListAsync();
                return salaries.Any() ? salaries.Average() : 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public async Task<bool> UpdateEmployeeAsync(Employee employee)
        {
            try
            {
                _appDbContext.Employee.Update(employee);
                await _appDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteEmployeeAsync(Employee employee)
        {
            try
            {
                _appDbContext.Employee.Remove(employee);
                await _appDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
