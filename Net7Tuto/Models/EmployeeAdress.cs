using System;
using System.ComponentModel.DataAnnotations;

namespace Net7Tuto.Models
{
    public class EmployeeAdress
    {
        [Key]
        public Guid AdressId { get; set; }

        public string Street { get; set; } = string.Empty;

        public string Number { get; set; } = string.Empty;

        public string PostalCode { get; set; } = string.Empty;

        public string Province { get; set; } = string.Empty;

    }
}

