using System.ComponentModel.DataAnnotations;

namespace EmployeeManagmentSystem.Data
{
    public class User: Base
    {
        [Required]
        public string Username { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
    }
}
 
