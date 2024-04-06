using System.ComponentModel.DataAnnotations;

namespace EmployeeManagmentSystem.Data
{
    public class Department: Base
    {
        public string DepartmentName { get; set; } = null!;
    }
}

