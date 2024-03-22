using Net7Tuto.Data;

namespace Net7Tuto.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DataContext _context;

        public EmployeeService(DataContext context)
        {
            _context = context;
        }
        
        public async Task<List<Employee>> GetAllEmployees()
        {
            var employees = await _context.Employees.Include(e => e.EmployeeAdress).Include(b => b.Department).ToListAsync();
            return employees;
        }

        public async Task<Employee?> GetSingleEmployee(Guid guid)
        {
            var employee = await  _context.Employees.FindAsync(guid) ;

            if (employee is null)
                return null;

            return employee;
        }


        public async Task<List<Employee>> AddEmployee(Employee employee)
        {
           _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return await _context.Employees.ToListAsync();
        }


		public async Task<List<Employee>?> UpdateEmployee(Guid id, Employee request)
		{
		    var employee = await _context.Employees.FindAsync(id);
		    if (employee is null)
		        return null;

		    employee.FirstName = request.FirstName;
		    employee.FirstName = request.FirstName;
		    employee.LastName = request.LastName;
		    employee.Place = request.Place;

		    await _context.SaveChangesAsync();

		   return await _context.Employees.ToListAsync();
		}

		public async Task<List<Employee>?> DeleteEmployee(Guid id)
		{
		   var employee = await _context.Employees.FindAsync(id);

	        if (employee is null)
		     return null;

		    _context.Employees.Remove(employee);
		    await _context.SaveChangesAsync();
		    return await _context.Employees.ToListAsync();
		}




	}
}

