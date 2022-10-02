using EmployeeDetails.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDetails.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees  { get; set; }
    }
}
