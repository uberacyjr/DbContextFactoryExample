using DbContextFactoryExample.Console.Models;
using Microsoft.EntityFrameworkCore;

namespace DbContextFactoryExample.Console
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}