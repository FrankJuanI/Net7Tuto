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
            var employees = await _context.Employees.ToListAsync();
            return employees;
        }

        public async Task<Employee?> GetSingleEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee is null)
                return null;

            return employee;
        }


        //public async Task<List<SuperHero>> AddHero(SuperHero hero)
        //{
        //    _context.SuperHeroes.Add(hero);
        //    await _context.SaveChangesAsync();
        //    return await _context.SuperHeroes.ToListAsync();
        //}

        //public async Task<List<SuperHero>?> DeleteHero(int id)
        //{
        //    var hero = await _context.SuperHeroes.FindAsync(id);

        //    if (hero is null)
        //        return null;

        //    _context.SuperHeroes.Remove(hero);
        //    await _context.SaveChangesAsync();
        //    return await _context.SuperHeroes.ToListAsync();
        //}



        //public async Task<List<SuperHero>?> UpdateHero(int id, SuperHero request)
        //{
        //    var hero = await _context.SuperHeroes.FindAsync(id);
        //    if (hero is null)
        //        return null;

        //    hero.Name = request.Name;
        //    hero.FirstName = request.FirstName;
        //    hero.LastName = request.LastName;
        //    hero.Place = request.Place;

        //    await _context.SaveChangesAsync();

        //    return await _context.SuperHeroes.ToListAsync();
        //}
    }
}

