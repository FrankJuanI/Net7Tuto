global using Microsoft.EntityFrameworkCore;


namespace Net7Tuto.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext>options) : base(options)
		{

		}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost;Database=Employees;User=sa;Password=J72016HGp?;Trusted_Connection=False;Encrypt=false");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}