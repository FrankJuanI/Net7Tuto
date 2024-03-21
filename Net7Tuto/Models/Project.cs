using System;
using System.ComponentModel.DataAnnotations;

namespace Net7Tuto.Models
{
    public class Project
    {
        [Key]
        public Guid ProjectId { get; set; }

        public string ProjectName { get; set; } = string.Empty;

        public Guid ClientId { get; set; } 

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

    }
}

