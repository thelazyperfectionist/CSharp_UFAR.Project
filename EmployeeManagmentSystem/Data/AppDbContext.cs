using Microsoft.EntityFrameworkCore;

namespace EmployeeManagmentSystem.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) 
        {

         }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<User> User { get; set; }
    }
}

