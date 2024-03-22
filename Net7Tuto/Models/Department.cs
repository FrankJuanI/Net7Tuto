using System;
using System.ComponentModel.DataAnnotations;

namespace Net7Tuto.Models
{
    public class Department
    {
        [Key]
        public Guid DepartmentId { get; set; }

        public string DepartmentName { get; set; } = string.Empty;

        //public ICollection<Employee>? Employees { get; set; }

        //public Employee? Employee { get; set; }

    }
}