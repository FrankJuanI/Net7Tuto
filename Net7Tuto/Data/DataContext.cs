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
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=gm4;Trusted_Connection=True;TrustServerCertificate=true");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAdress> EmployeeAdresses { get; set; }
        public DbSet<Department> Departments { get; set; }

        //public DbSet<Client> Clients { get; set; }
        //public DbSet<Project> Proyects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}