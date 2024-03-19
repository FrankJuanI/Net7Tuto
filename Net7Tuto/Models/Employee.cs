namespace Net7Tuto.Models
{
	public class Employee
	{
		public Guid Id { get; set; }

		public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Place { get; set; } = string.Empty;

		public Guid AdressId { set; get; } 

		public string Seniority { get; set; } = string.Empty;

		public int Salary { get; set; }

		public string CurrentProyect { get; set; } = string.Empty;
    }

}


//public class EmployeesAdresses
//{
//	public int Id { get; set; }

//	public string Street { get; set; } = string.Empty;

//	public string Number { get; set; } = string.Empty;

//	public string PostalCode { get; set; } = string.Empty;

//	public string Province { get; set; } = string.Empty;

//}

//public class Proyects
//{
//	public int Id { get; set; }

//	public string ProyectName { get; set; } = string.Empty;

//	public int EmployeeID { get; set; }
//}