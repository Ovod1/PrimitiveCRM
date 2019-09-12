using System.Data.Entity;
namespace CrmBL.Model
{
    public class CrmContext : DbContext
    {
        public CrmContext() : base("CrmConnection") { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Head> Heads { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
