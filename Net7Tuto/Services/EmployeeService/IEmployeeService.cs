﻿namespace Net7Tuto.Services.EmployeeService
{
	public interface IEmployeeService
	{
        Task<List<Employee>> GetAllEmployees();

        //Task<SuperHero?> GetSingleHero(int id);

        //Task<List<SuperHero>> AddHero(SuperHero hero);

        //Task<List<SuperHero>?> UpdateHero(int id, SuperHero request);

        //Task<List<SuperHero>?> DeleteHero(int id);
    }
}

