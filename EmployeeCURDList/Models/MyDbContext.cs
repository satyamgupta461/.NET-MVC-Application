using System;
using Microsoft.EntityFrameworkCore;
namespace EmployeeCURDList.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        //public MyDbContext(DbContextOptions options) : base(options)
        //{
        //}

        public DbSet<Employee> Employee { get; set; }

        
    }
}