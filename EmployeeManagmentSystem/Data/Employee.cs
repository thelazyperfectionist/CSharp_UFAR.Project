using System.ComponentModel.DataAnnotations;

namespace EmployeeManagmentSystem.Data
{
    public class Employee : Base
    {
        [Required]
        public string EmployeeName { get; set; } = null!;

        public string EmployeeSurname { get; set; } = null!;

        public string Gender { get; set; } = null!;

        public string City { get; set; } = null!;

        public string DepartmentName { get; set; } = null!;

        public string JobTitle { get; set; } = null!;

        public string Email { get; set; } = null!;

        [Required]
        public decimal Salary { get; set; }
    }
}

