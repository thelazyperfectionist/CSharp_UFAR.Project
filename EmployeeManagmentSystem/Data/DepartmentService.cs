using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagmentSystem.Data
{
    public class DepartmentService
    {
        private readonly AppDbContext _appDbContext;

        public DepartmentService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Department>> GetAllDepartmentsAsync()
        {
            return await _appDbContext.Department.ToListAsync();
        }

        public async Task<Department> GetDepartmentAsync(int id)
        {
            return await _appDbContext.Department.FirstOrDefaultAsync(d => d.Id == id) ?? throw new Exception("Department not found");
        }

        public async Task<bool> InsertDepartmentAsync(Department department)
        {
            await _appDbContext.Department.AddAsync(department);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateDepartmentAsync(Department department)
        {
            _appDbContext.Department.Update(department);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteDepartmentAsync(Department department)
        {
            _appDbContext.Department.Remove(department);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
    }
}


