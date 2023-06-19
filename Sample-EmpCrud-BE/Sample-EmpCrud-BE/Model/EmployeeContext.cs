using Microsoft.EntityFrameworkCore;

namespace Sample_EmpCrud_BE.Model
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options) 
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
