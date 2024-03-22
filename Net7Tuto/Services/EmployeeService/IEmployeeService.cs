namespace Net7Tuto.Services.EmployeeService
{
	public interface IEmployeeService
	{
        Task<List<Employee>> GetAllEmployees();

        Task<Employee?> GetSingleEmployee(Guid id);

        Task<List<Employee>> AddEmployee(Employee employee);

        Task<List<Employee>?> UpdateEmployee(Guid id, Employee request);

        Task<List<Employee>?> DeleteEmployee(Guid id);
    }
}

