using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlServer("Data Source=localhost;Initial Catalog=EmpDB;User Id=sa;Password=Pit.van-11;");

        public DbSet<Employee1> Employee1 { get; set; }
       /// public DbSet<LoginModel> login { get; set; }
    }
}
