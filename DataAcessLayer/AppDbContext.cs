using AspCoreWebAPICRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace AspCoreWebAPICRUD.DataAcessLayer
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
                
        }
        public DbSet<Employee> EmpDetails { get; set; }
        public DbSet<Student> StuDetails { get; set; }

    }
}
