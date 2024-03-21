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
            optionsBuilder.UseSqlServer("Server=localhost;Database=gm2;User=sa;Password=J72016HGp?;Trusted_Connection=False;Encrypt=false");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAdress> EmployeeAdresses { get; set; }
        public DbSet<Department> Departments { get; set; }
        //public DbSet<Client> Clients { get; set; }
        //public DbSet<Project> Proyects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>()
            //    .HasOne(a => a.EmployeeAdress)
            //    .WithOne(e => e.Employee)
            //    .HasForeignKey<Employee>(a => a.EmployeeAdress);

            //modelBuilder.Entity<Department>()
            //    .HasMany(a => a.Employees)
            //    .WithOne(e => e.Department)
            //    .HasForeignKey(a => a.DepartmentId);

            //modelBuilder.Entity<Client>()
            //    .HasMany(a => a.Projects)
            //    .WithOne(e => e.Client)
            //    .HasForeignKey(a => a.ClientId);

            //modelBuilder.Entity<Project>()
            //    .HasMany(e => e.Employees)
            //    .WithMany(a => a.Projects);
        }
    }
}