using Microsoft.EntityFrameworkCore;
using webapi_demo.Models;

namespace webapi_demo.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}