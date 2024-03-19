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

        //[HttpGet("/id")]
        //public async Task<ActionResult<SuperHero>> GetSingleHero(int id)
        //{
        //    var result = await _superHeroService.GetSingleHero(id);
        //    if (result is null)
        //        return NotFound("Hero not found");

        //    return Ok(result);
        //}

        //[HttpPost]
        //public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        //{
        //    var result = await _superHeroService.AddHero(hero);
        //    return Ok(result);
        //}


        //[HttpPut("{id}")]
        //public async Task<ActionResult<List<SuperHero>>> UpdateHero(int id, SuperHero request)
        //{
        //    var result = await _superHeroService.UpdateHero(id, request);
        //    if (result is null)
        //        return NotFound("Hero not found");

        //    return Ok(result);
        //}

        //[HttpDelete("{id}")]
        //public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        //{
        //    var result = await _superHeroService.DeleteHero(id);
        //    if (result is null)
        //        return NotFound("Hero not found");

        //    return Ok(result);
            
        //}
    }
}

