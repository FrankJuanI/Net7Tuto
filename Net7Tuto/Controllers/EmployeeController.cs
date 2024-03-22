global using Net7Tuto.Models;
using Microsoft.AspNetCore.Mvc;
using Net7Tuto.Services.EmployeeService;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Net7Tuto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeeConttroller : ControllerBase
    {

        private readonly IEmployeeService _employeeService;

        public EmployeeConttroller(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


		[HttpGet("/employees")]
        public async Task<ActionResult<List<Employee>>> GetAllEmployees()
        {
            return await _employeeService.GetAllEmployees();
        }


        [HttpGet("/id")]
        public async Task<ActionResult<Employee>> GetSingleEmployee(Guid id)
        {
            var result = await _employeeService.GetSingleEmployee(id);
            if (result is null)
                return NotFound("Employee not found");

            return Ok(result);
        }

		[HttpPost]
        public async Task<ActionResult<List<Employee>>> AddEmployee(Employee employee)
        {
            var result = await _employeeService.AddEmployee(employee);
            return Ok(result);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<List<Employee>>> UpdateEmployee(Guid id, Employee request)
        {
            var result = await _employeeService.UpdateEmployee(id, request);
            if (result is null)
               return NotFound("Employee not found");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Employee>>> DeleteEmployee(Guid id)
        {
            var result = await _employeeService.DeleteEmployee(id);
            if (result is null)
                return NotFound("Hero not found");

            return Ok(result);

        }
    }
}

