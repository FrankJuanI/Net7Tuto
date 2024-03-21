using System;
using System.ComponentModel.DataAnnotations;

namespace Net7Tuto.Models
{
    public class Client
    {
        [Key]
        public Guid ClientId { get; set; }

        public string ClientName { get; set; } = string.Empty;

        public ICollection<Project> Projects { get; set; } = new List<Project>();

    }
}

