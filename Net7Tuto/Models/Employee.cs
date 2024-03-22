using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net7Tuto.Models
{
    public class Employee
    {
        [Key]
        public Guid EmployeeId { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Seniority { get; set; } = string.Empty;

        public int Salary { get; set; }

        public virtual EmployeeAdress? EmployeeAdress { get; set; }

        public virtual Department? Department { get; set; }

    }
}


